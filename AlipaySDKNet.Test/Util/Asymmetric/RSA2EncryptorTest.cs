using NUnit.Framework;
using Aop.Api.Util.Asymmetric;

namespace Test
{
    public class RSA2EncryptorTest
    {
        private const string RSA2_PublicKey = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAnUZKeiy1QsXMxNGIZ7jLHV6hrzl/hVDLo1e0JI+3gtEzsSbpr3HT8WUszLRWPesAQWVDkZmpuJ5lVFzltDeFl0l68QKI+nL063LQUe25dM6IP+xxIOem5arVa7SjbE16YZlXe9fxnc3wQWrF7WihCa07PbT3vBRsJjd8l26BV0LvybXk2/fKejXjEGMLvpLNW5NnTKTY9wUiC27lc/V/YcC3xV1Ytqii9oCbZEqVHjhRljc9YQm9hne7AInPT3Ju0BZfmykoet8FESd3itrF7UTAWQVY3doe4LhWNpDd/02nyeeNU0sRWc1aPtzWMZN5aa1DhArQ1McQ0AMK/MAYhQIDAQAB";
        private const string RSA2_PrivateKey = @"MIIEogIBAAKCAQEAnUZKeiy1QsXMxNGIZ7jLHV6hrzl/hVDLo1e0JI+3gtEzsSbpr3HT8WUszLRWPesAQWVDkZmpuJ5lVFzltDeFl0l68QKI+nL063LQUe25dM6IP+xxIOem5arVa7SjbE16YZlXe9fxnc3wQWrF7WihCa07PbT3vBRsJjd8l26BV0LvybXk2/fKejXjEGMLvpLNW5NnTKTY9wUiC27lc/V/YcC3xV1Ytqii9oCbZEqVHjhRljc9YQm9hne7AInPT3Ju0BZfmykoet8FESd3itrF7UTAWQVY3doe4LhWNpDd/02nyeeNU0sRWc1aPtzWMZN5aa1DhArQ1McQ0AMK/MAYhQIDAQABAoIBAEZtx8RWaQVx1nT87/yiwDJywizZrsVgnRCUodMNmLw4OtHF/zfV3XdoO1ugFk68Ae1HD68QBPTr2ayhvSurAWPyP9/Vpsmg2RTm4WsO7dHk+xbFJxP5KMAIdHI6/kPtnjQ+mvKWjViBdGmXCvN5u0O+E51agOX0r0md52lYzwrn9XsPudhrfwrRVnWXHhGNDglvSz7I8W+5SztvUC5TXoXTajNODadX7l+Azkv7kXRBbfSkNAm9JVJmAQTpkEVYINDozYjz6vizta8s/VAEizUhqjiIjXjtIABHhqxt1TjDNpJIrNEk1FV+JotxHAdWix6u4bDb6+njRwlJxeL/tAECgYEA5OtBOxwyTy0ruZj+NFjtm6h0sMCVqBl0AA8f1iKK53YIcbhuou574iJXmIgJnqYCxP7h4mhVT+l3zCM3y1wL4rAYHXWcLbrl5N/KBa7B4qE2NEFdXAaO24RlVGBHbCkTnx5hy5RbtZZpYz8IM02V0IYRQFhbjr87k1iy14EIxUECgYEAr+FOafdFto/Iup/+eOeW5GSaJ15ZghZhsHEalg4mMstbvaKmedxc/lARTdXsDxHYybQHyQmm3Q+o2T29BI2wHXCLO/SetIHygqqx4Nde4ySWNiuFLuXJSJ31pXHCeCoaN+9kr/haLwv6c8IKX8FSLkTnnoufYC4LvmT89PNhbkUCgYBal/+otO/0BZxYRwPTE551C6WijZSsgeY2X8XpqKHwF/Yfiy29rUO5qn2gD7Y+4tQVwgkC4OdiSLLwRr+96x+JBseEYRb9wglZGneI6DAy0DnzVCruUGoY1byEN9YMJ/Vr80oglwX0RyJN9JP6Oaoga+5H2K/jPisFlQSx5I7kAQKBgCLaWAqhqJvr1FA/QlM9OWabFP02MjCYNNWdJDKWLTWlnNFweOLvKzJuNW+iM7wswjP+TAins/xcjQ43sMxFM6Ax3DWOXSDSG3ePUd6Hb1M9vdKQPz0y5fdQ7gvSBkJ/vWBWPTKt2Vk3W3MzAZFGIv3uQ6PkcTnDBiq9om78B9OtAoGAOQwOBtzKnEN6XZQq1HvL0oGJI12IxidcHq2GKU2tMAYYzRyC5lZ76JUVf2qpPiMdpy46Psd32SvJNC1U8EsiovY5SH41Wty8EIg2BNVotulSoLNAG2nElIM6zzOkxNBkhBzpOzdvbCzTSSGcuGttpY2n0EyRejxlM2br5mL8RmA=";
        private readonly IAsymmetricEncryptor Encryptor = new RSA2Encryptor();

        [Test()]
        public void should_pass_verify_when_sign_is_self_generated()
        {
            //given
            string content = "test";
            string sign = Encryptor.Sign(content, "UTF-8", RSA2_PrivateKey);

            //when
            bool success = Encryptor.Verify(content, "UTF-8", RSA2_PublicKey, sign);

            //then
            Assert.AreEqual(success, true);
        }

        [Test()]
        public void should_return_same_content_after_encrypt_and_decrypt()
        {
            //given
            string source = "test";
            string cipherTextBase64 = Encryptor.Encrypt(source, "UTF-8", RSA2_PublicKey);

            //when
            string target = Encryptor.Decrypt(cipherTextBase64, "UTF-8", RSA2_PrivateKey);

            //then
            Assert.AreEqual(target, source);
        }
    }
}
