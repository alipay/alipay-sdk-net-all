using System.Collections.Generic;

namespace Aop.Api
{
    public class AlipayConfig
    {
        /// <summary>
        /// 网关地址
        /// 线上：https://openapi.alipay.com/gateway.do
        /// 沙箱：https://openapi.alipaydev.com/gateway.do
        /// </summary>
        public string ServerUrl { get; set; } = "https://openapi.alipay.com/gateway.do";

        /// <summary>
        /// 开放平台上创建的应用的ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 报文格式，推荐：json
        /// </summary>
        public string Format { get; set; } = "json";

        /// <summary>
        /// 字符串编码，推荐：UTF-8
        /// </summary>
        public string Charset { get; set; } = "UTF-8";

        /// <summary>
        /// 签名算法类型，推荐：RSA2
        /// </summary>
        public string SignType { get; set; } = "RSA2";

        /// <summary>
        /// 商户私钥
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

        /// <summary>
        /// HTTP代理服务器主机地址
        /// </summary>
        public string ProxyHost { get; set; }

        /// <summary>
        /// HTTP代理服务器端口
        /// </summary>
        public int ProxyPort { get; set; }

        /// <summary>
        /// 自定义HTTP Header
        /// </summary>
        public Dictionary<string, string> CustomHeaders { get; set; }

        /// <summary>
        /// 连接超时，单位：毫秒
        /// 注：C#中连接超时将设置为HttpWebRequest的Timeout参数，表示发起请求到服务端首次返回数据的超时时长，单位毫秒
        /// 上传文件类请求由于请求完全发送到服务端的时间较长，服务端必须等待接收完整请求后才可做出响应，此种情况下，可适当延长此超时时间
        /// </summary>
        public int ConnectTimeout { get; set; } = 100000;

        /// <summary>
        /// 读取超时，单位：毫秒
        /// 注：C#中读取超时将设置为HttpWebRequest的ReadWriteTimeout参数，表示服务端首次返回数据后，等待后续数据的超时时长，单位毫秒
        /// </summary>
        public int ReadTimeout { get; set; } = 15000;
    }
}