using NUnit.Framework;
using Aop.Api.Util.Asymmetric;
using System;
using Aop.Api;

namespace Test
{
    public class RSAEncryptorTest
    {
        private const string RSA_PublicKey = @"MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQCY6vX+24mylo+wDCOcjHfMbG2CRAG8ek9O0kPd/UkxbxHIvPaSI4uHxe9HhASd7S4De6IkwCtAKPk4xUCaVkpNSxlp91FkMIA+k5a1tJshOxsQrJh6RdpIO/ZTN4UW61+ME5cVMFRWNZtSNIKyppf8YVQaub2pzhawGoHoaBaCswIDAQAB";
        private const string RSA_PrivateKey = @"MIICXAIBAAKBgQCY6vX+24mylo+wDCOcjHfMbG2CRAG8ek9O0kPd/UkxbxHIvPaSI4uHxe9HhASd7S4De6IkwCtAKPk4xUCaVkpNSxlp91FkMIA+k5a1tJshOxsQrJh6RdpIO/ZTN4UW61+ME5cVMFRWNZtSNIKyppf8YVQaub2pzhawGoHoaBaCswIDAQABAoGAOO/znGt9/+MTqUc700RyLsmIlOJhix43fW/JGVT/9coXYxkI7i0R/QH0MDq1xV/UrDNSkkCDWiZndX3sqgrLKxqlMeYbyjOsAF2vYrwiiTEPzwGe/jjuQQhRBZ9w29xOTncDxKPV7ua761LdimqmH5y66PKQumTtBnU2NvvXMrECQQDtkdItfdP+5M4VLqYw1MvEWeJcnf/Qq6I3xKkZ/uXqaZoAYdgumw49aCW9zR62cpgFFxVEdkDk2JgWvyVUQd93AkEApMfwTBsxMYVodgQusuhfn5MquwHNe97Vc1BBucARGVxkXthgSAyM7hP5F4Fh6k6z32lhYqEjp011ger2FXcdpQJAL8ql/YDSpPRigOBhjnFAjL+IShl+3PuqJo3pdtFQb1fPI0SLuNR4iOHqtcQN6aYj7uI15Q/k/iSUc/8AA3M9AQJATDYo/popA3VnXgYLLzXoXB6tybZIunzSjjXVYDrj7a3cwj0jMs+TMt3L/EIb7kmeSbssjnhmzA84RPFOBZmE/QJBALOQwPN65a9aUri4uabpBltBBlrBei/m6ozq0hJJncgN14BZg947AYiA9OKjoxDtQFOrvSIdxznWPBxdHdnThFI=";
        private readonly IAsymmetricEncryptor Encryptor = new RSA2Encryptor();

        [Test()]
        public void should_pass_verify_when_sign_is_self_generated()
        {
            //given
            string content = "test";
            string sign = Encryptor.Sign(content, "UTF-8", RSA_PrivateKey);

            //when
            bool success = Encryptor.Verify(content, "UTF-8", RSA_PublicKey, sign);

            //then
            Assert.AreEqual(success, true);
        }

        [Test()]
        public void should_get_exception_when_content_to_be_sign_is_null()
        {
            //given
            string content = null;
            //then
            AopException ex = Assert.Throws<AopException>(() => Encryptor.Sign(content, "UTF-8", RSA_PrivateKey));
            Assert.AreEqual(ex.Message.Contains("待签名内容不可为Null"), true);
        }

        [Test()]
        public void should_get_exception_when_private_key_is_invalid()
        {
            //given
            string content = "test";
            string privateKey = @"BLSi7EW+cBAfuuepOfANrWGt5jSwSkD+6nf6PsWH2R07ZwRFDD3S3G9RiYS0aR9tgY1nggfTP0lz2uiVgAYO4A8=";

            //then
            AopException ex = Assert.Throws<AopException>(() => Encryptor.Sign(content, "UTF-8", privateKey));
            Assert.AreEqual(ex.Message.Contains("签名遭遇异常，请检查私钥格式是否正确"), true);
        }

        [Test()]
        public void should_return_same_content_after_encrypt_and_decrypt()
        {
            //given
            string source = "test";
            string cipherTextBase64 = Encryptor.Encrypt(source, "UTF-8", RSA_PublicKey);

            //when
            string target = Encryptor.Decrypt(cipherTextBase64, "UTF-8", RSA_PrivateKey);

            //then
            Assert.AreEqual(target, source);
        }
    }
}
