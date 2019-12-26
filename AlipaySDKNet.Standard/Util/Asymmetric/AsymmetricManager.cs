namespace Aop.Api.Util.Asymmetric
{
    /// <summary>
    /// 非对称加密算法管理类
    /// </summary>
    public static class AsymmetricManager
    {
        /// <summary>
        /// 根据算法名称（RSA、RSA2、SM2）实例化具体算法的加密器
        /// </summary>
        /// <param name="type">算法名称</param>
        /// <returns>具体算法的加密器</returns>
        public static IAsymmetricEncryptor GetByName(string type)
        {
            if ("RSA".Equals(type))
            {
                return new RSAEncryptor();
            }
            if ("RSA2".Equals(type))
            {
                return new RSA2Encryptor();
            }
            if ("SM2".Equals(type))
            {
                return new SM2Encryptor();
            }

            throw new AopException("无效的非对称加密类型:[" + type + "]，可选值为：RSA、RSA2和SM2。");
        }
    }
}
