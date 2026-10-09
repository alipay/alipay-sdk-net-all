using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOpenbizmocktoolsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOpenbizmocktoolsCreateModel : AopObject
    {
        /// <summary>
        /// 接口赋权
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 允许的签名类型
        /// </summary>
        [XmlElement("allow_sign_types")]
        public string AllowSignTypes { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("app_name")]
        public string AppName { get; set; }

        /// <summary>
        /// 应用的APPID
        /// </summary>
        [XmlElement("app_number")]
        public string AppNumber { get; set; }

        /// <summary>
        /// 应用类型
        /// </summary>
        [XmlElement("application_type")]
        public string ApplicationType { get; set; }

        /// <summary>
        /// 字符格式
        /// </summary>
        [XmlElement("charset_type")]
        public string CharsetType { get; set; }

        /// <summary>
        /// 加密类型
        /// </summary>
        [XmlElement("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 网关地址
        /// </summary>
        [XmlElement("gateway_url")]
        public string GatewayUrl { get; set; }

        /// <summary>
        /// group_id值
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 抬头
        /// </summary>
        [XmlElement("header")]
        public string Header { get; set; }

        /// <summary>
        /// 接口英文名
        /// </summary>
        [XmlElement("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// isvAPPID
        /// </summary>
        [XmlElement("isv_app_id")]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 是否压测
        /// </summary>
        [XmlElement("load_test")]
        public string LoadTest { get; set; }

        /// <summary>
        /// mock配置
        /// </summary>
        [XmlElement("mock_config")]
        public string MockConfig { get; set; }

        /// <summary>
        /// 通知字段
        /// </summary>
        [XmlElement("notify_fields")]
        public string NotifyFields { get; set; }

        /// <summary>
        /// 通知场景
        /// </summary>
        [XmlElement("notify_triggers")]
        public string NotifyTriggers { get; set; }

        /// <summary>
        /// OID
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }

        /// <summary>
        /// OPENID值
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 输出字段
        /// </summary>
        [XmlElement("outputs")]
        public string Outputs { get; set; }

        /// <summary>
        /// 功能包
        /// </summary>
        [XmlElement("package_code")]
        public string PackageCode { get; set; }

        /// <summary>
        /// 商家账号
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 接入方式
        /// </summary>
        [XmlElement("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// 公钥
        /// </summary>
        [XmlElement("public_key")]
        public string PublicKey { get; set; }

        /// <summary>
        /// 查询
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 回调地址
        /// </summary>
        [XmlElement("return_url_address")]
        public string ReturnUrlAddress { get; set; }

        /// <summary>
        /// scope值
        /// </summary>
        [XmlElement("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 加密密钥
        /// </summary>
        [XmlElement("secret_key")]
        public string SecretKey { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [XmlElement("signature_type")]
        public string SignatureType { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订阅标签
        /// </summary>
        [XmlElement("sub_tag")]
        public string SubTag { get; set; }

        /// <summary>
        /// 订阅方式
        /// </summary>
        [XmlElement("subscribe_type")]
        public string SubscribeType { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [XmlElement("test_url")]
        public string TestUrl { get; set; }

        /// <summary>
        /// 超时时间
        /// </summary>
        [XmlElement("timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// UID值
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 是否强制加密
        /// </summary>
        [XmlElement("use_encrypt")]
        public string UseEncrypt { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("version_no")]
        public string VersionNo { get; set; }
    }
}
