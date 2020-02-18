namespace Aop.Api.Util.Asymmetric
{
    /// <summary>
    /// RSA2算法加密器
    /// 签名部分采用SHA256算法进行摘要计算，其余部分与RSA算法相同
    /// </summary>
    public class RSA2Encryptor : RSAEncryptor
    {
        /// <summary>
        /// RSA2算法签名采用SHA256摘要算法
        /// </summary>
        /// <returns>摘要算法名称</returns>
        protected override string GetShaType()
        {
            return "SHA256";
        }
    }
}
