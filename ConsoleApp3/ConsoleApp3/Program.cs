using System;

public class CaesarCipher
{
    private int shift;

    public CaesarCipher(int shift)
    {
        this.shift = shift;
    }
    public string Encrypt(string plainText)
    {
        char[] chars = plainText.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];

            if (char.IsLetter(c))
            {
                c = (char)(c + shift);

                if ((char.IsLower(chars[i]) && c > 'z') || (char.IsUpper(chars[i]) && c > 'Z'))
                {
                    c = (char)(c - 26);
                }
            }

            chars[i] = c;
        }

        return new string(chars);
    }

    public string Decrypt(string cipherText)
    {
        int reverseShift = 26 - shift;
        CaesarCipher reverseCipher = new CaesarCipher (reverseShift);
        return reverseCipher.Encrypt(cipherText);
    }
}
class Program
{
    static void Main()
    {
        CaesarCipher cipher = new CaesarCipher(3);

        string plainText = "A little kitten is sitting on a tree";
        string cipherText = cipher.Encrypt(plainText);
        string decryptedText = cipher.Decrypt(cipherText);

        Console.WriteLine($"Зашифрованный текст: {cipherText}");
        Console.WriteLine($"Расшифрованный текст: {decryptedText}");
    }
}