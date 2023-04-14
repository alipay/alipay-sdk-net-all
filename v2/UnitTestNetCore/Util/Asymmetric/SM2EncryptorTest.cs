using NUnit.Framework;
using Aop.Api.Util.Asymmetric;

namespace Test
{
    public class SM2EncryptorTest
    {
        private const string SM2_PublicKey = @"MFkwEwYHKoZIzj0CAQYIKoEcz1UBgi0DQgAEtKLsRb5wEB+656k58A2tYa3mNLBKQP7qd/o+xYfZHTtnBEUMPdLcb1GJhLRpH22BjWeCB9M/SXPa6JWABg7gDw==";
        private const string SM2_PrivateKey = @"MIGHAgEAMBMGByqGSM49AgEGCCqBHM9VAYItBG0wawIBAQQguNPwEr5WCpjhQKyNXQR/VhIm1uEDgjV0o82Hr6v4bEuhRANCAAS0ouxFvnAQH7rnqTnwDa1hreY0sEpA/up3+j7Fh9kdO2cERQw90txvUYmEtGkfbYGNZ4IH0z9Jc9rolYAGDuAP";
        private readonly IAsymmetricEncryptor Encryptor = new SM2Encryptor();

        [Test()]
        public void should_pass_verify_when_sign_is_self_generated()
        {
            //given
            string content = "test";
            string sign = Encryptor.Sign(content, "UTF-8", SM2_PrivateKey);

            //when
            bool success = Encryptor.Verify(content, "UTF-8", SM2_PublicKey, sign);

            //then
            Assert.AreEqual(success, true);
        }

        [Test()]
        public void should_pass_verify_when_sign_is_other_sdk_language_generated()
        {
            //given
            string content = "test";
            //Java SDK生成的签名（ECC对相同内容每次生成的签名值都可能不一样）
            string sign = @"MEUCIQDw5jNHxCm3904JqV9gTK93Mg67vLqWiweaamjVM/PoyQIga+eSzNG4/8xJK1H2h4BiHqsrz8V2C7TsoypH4F2t4v8=";

            //when
            bool success = Encryptor.Verify(content, "UTF-8", SM2_PublicKey, sign);

            //then
            Assert.AreEqual(success, true);
        }

        [Test()]
        public void should_return_same_content_after_encrypt_and_decrypt()
        {
            //given
            string source = "test";
            string cipherTextBase64 = Encryptor.Encrypt(source, "UTF-8", SM2_PublicKey);

            //when
            string target = Encryptor.Decrypt(cipherTextBase64, "UTF-8", SM2_PrivateKey);

            //then
            Assert.AreEqual(target, source);
        }

        [Test()]
        public void should_be_able_to_decrypt_when_cipher_text_generated_by_other_sdk_languag()
        {
            //given
            string source = "test";
            string cipherTextBase64 = @"BL8cXPFPkFn4pxIQ15cIReIg4szxEpeeqSe3DlLTIdRKrUA0/TJZ6u2lPAdsHD1YRUo0sc436YcADAFjaPkgvH3085h/80vDYSQypKH4i23ujZnzhodV78QasJuNGFa2XEs/ZSM=";

            //when
            string target = Encryptor.Decrypt(cipherTextBase64, "UTF-8", SM2_PrivateKey);

            //then
            Assert.AreEqual(target, source);
        }
    }
}
