namespace Aop.Api
{
    public class CertParams
    {
        /// <summary>
        /// 商户证书储存本地路径
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
    }
}