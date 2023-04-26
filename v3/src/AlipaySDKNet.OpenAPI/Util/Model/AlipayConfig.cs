namespace AlipaySDKNet.OpenAPI.Util.Model
{
    /// <summary>
    /// alipay参数设置
    /// </summary>
    public class AlipayConfig
    {
        /// <summary>
        /// 网关地址
        /// </summary>
        public string ServerUrl { get; set; }

        /// <summary>
        /// 开放平台上创建的应用的ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户私钥字符串
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// 支付宝公钥字符串（公钥模式下设置，证书模式下无需设置）
        /// </summary>
        public string AlipayPublicKey { get; set; }

        /// <summary>
        /// 商户应用公钥证书路径（证书模式下设置，公钥模式下无需设置）
        /// </summary>
        public string AppCertPath { get; set; }

        /// <summary>
        /// 支付宝公钥证书路径（证书模式下设置，公钥模式下无需设置）
        /// </summary>
        public string AlipayPublicCertPath { get; set; }

        /// <summary>
        /// 支付宝根证书路径（证书模式下设置，公钥模式下无需设置）
        /// </summary>
        public string RootCertPath { get; set; }

        /// <summary>
        /// 指定商户应用公钥证书内容字符串，该字段与AppCertPath只需指定一个，优先以该字段的值为准（证书模式下设置，公钥模式下无需设置）
        /// </summary>
        public string AppCertContent { get; set; }

        /// <summary>
        /// 指定支付宝公钥证书内容字符串，该字段与AlipayPublicCertPath只需指定一个，优先以该字段的值为准（证书模式下设置，公钥模式下无需设置）
        /// </summary>
        public string AlipayPublicCertContent { get; set; }

        /// <summary>
        /// 指定根证书内容字符串，该字段与RootCertPath只需指定一个，优先以该字段的值为准（证书模式下设置，公钥模式下无需设置）
        /// </summary>
        public string RootCertContent { get; set; }

        /// <summary>
        /// 敏感信息对称加密算法类型，推荐：AES
        /// </summary>
        public string EncryptType { get; set; } = "AES";

        /// <summary>
        /// 敏感信息对称加密算法密钥
        /// </summary>
        public string EncryptKey { get; set; }
    }
}