using System;
using System.Text;
using System.Security.Cryptography;
using System.Text.Json;
using System.Collections.Generic;

/**
	* A class to encrypt and decrypt strings using
	* the cipher AES-256-CBC used in Laravel.
	*/
class Encrypter
{
	static readonly string KEY = "8UHjPgXZzXCGkhxV2QCnooyJexUzvJrO";
	private static readonly Encoding encoding = Encoding.UTF8;

	public static string Encrypt(string plainText)
	{
		try
		{
			RijndaelManaged aes = new RijndaelManaged();
			aes.KeySize = 256;
			aes.BlockSize = 128;
			aes.Padding = PaddingMode.PKCS7;
			aes.Mode = CipherMode.CBC;

			aes.Key = encoding.GetBytes(KEY);
			aes.GenerateIV();

			ICryptoTransform AESEncrypt = aes.CreateEncryptor(aes.Key, aes.IV);
			byte[] buffer = encoding.GetBytes(plainText);

			string encryptedText = Convert.ToBase64String(AESEncrypt.TransformFinalBlock(buffer, 0, buffer.Length));

			String mac = "";

			mac = BitConverter.ToString(HmacSHA256(Convert.ToBase64String(aes.IV) + encryptedText, KEY)).Replace("-", "").ToLower();

			var keyValues = new Dictionary<string, object>
			{
				{ "iv", Convert.ToBase64String(aes.IV) },
				{ "value", encryptedText },
				{ "mac", mac },
			};

			return Convert.ToBase64String(encoding.GetBytes(JsonSerializer.Serialize(keyValues)));
		}
		catch (Exception e)
		{
			throw new Exception("Error encrypting: " + e.Message);
		}
	}

	public static string Decrypt(string plainText)
	{
		try
		{
			RijndaelManaged aes = new RijndaelManaged();
			aes.KeySize = 256;
			aes.BlockSize = 128;
			aes.Padding = PaddingMode.PKCS7;
			aes.Mode = CipherMode.CBC;
			aes.Key = encoding.GetBytes(KEY);

			// Base 64 decode
			byte[] base64Decoded = Convert.FromBase64String(plainText);
			string base64DecodedStr = encoding.GetString(base64Decoded);

			// JSON Decode base64Str
			var payload = JsonSerializer.Deserialize<Dictionary<string, string>>(base64DecodedStr);

			aes.IV = Convert.FromBase64String(payload["iv"]);

			ICryptoTransform AESDecrypt = aes.CreateDecryptor(aes.Key, aes.IV);
			byte[] buffer = Convert.FromBase64String(payload["value"]);

			return encoding.GetString(AESDecrypt.TransformFinalBlock(buffer, 0, buffer.Length));
		}
		catch (Exception e)
		{
			throw new Exception("Error decrypting: " + e.Message);
		}
	}

	static byte[] HmacSHA256(String data, String key)
	{
		using (HMACSHA256 hmac = new HMACSHA256(encoding.GetBytes(key)))
		{
			return hmac.ComputeHash(encoding.GetBytes(data));
		}
	}
}


class TestEncryption
{
	public void Start()
	{
		// The sample encryption key. Must be 32 characters.
		string Key = "8UHjPgXZzXCGkhxV2QCnooyJexUzvJrO";

		// The sample text to encrypt and decrypt.
		string Text = "Here is some text to encrypt!";

		// Encrypt and decrypt the sample text via the Aes256CbcEncrypter class.
		string Encrypted = Encrypter.Encrypt(Text);
		string Decrypted = Encrypter.Decrypt(Encrypted);

		// Show the encrypted and decrypted data and the key used.
		Console.WriteLine("Original: {0}", Text);
		Console.WriteLine("Key: {0}", Key);
		Console.WriteLine("Encrypted: {0}", Encrypted);
		Console.WriteLine("Decrypted: {0}", Decrypted);
	}
}
