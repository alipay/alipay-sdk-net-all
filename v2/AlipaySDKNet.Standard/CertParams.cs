namespace Aop.Api
{
    public class CertParams
    {
        /// <summary>
        /// 商户应用公钥证书储存本地路径
        /// </summary>
        public string AppCertPath { get; set; }

        /// <summary>
        /// 支付宝公钥证书储存本地路径
        /// </summary>
        public string AlipayPublicCertPath { get; set; }

        /// <summary>
        /// 支付宝根证书储存本地路径
        /// </summary>
        public string RootCertPath { get; set; }

        /// <summary>
        /// 商户应用公钥证书文件内容字符串，与AppCertPath只需指定一个，优先以该字段为准
        /// </summary>
        public string AppCertContent { get; set; }

        /// <summary>
        /// 支付宝公钥证书文件内容字符串，与AlipayPublicCertPath只需指定一个，优先以该字段为准
        /// </summary>
        public string AlipayPublicCertContent { get; set; }

        /// <summary>
        /// 支付宝根证书文件内容字符串，与RootCertPath只需指定一个，优先以该字段的值为准
        /// </summary>
        public string RootCertContent { get; set; }
    }
}