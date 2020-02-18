using System;

namespace Aop.Api.Util
{
    /// <summary>
    /// RSA签名工具类。
    /// </summary>
    public class RSAUtil
    {
        [Obsolete("建议直接使用AlipaySignature.RSASign方法")]
        public static string RSASign(string data, string privateKeyPem, string charset)
        {
            return AlipaySignature.RSASign(data, privateKeyPem, charset, "RSA");
        }
    }
}

