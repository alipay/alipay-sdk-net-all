using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDigitalidentityCertificateSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDigitalidentityCertificateSyncModel : AopObject
    {
        /// <summary>
        /// 信息核验模式，该字段用于控制传入的信息与支付宝侧信息的核验对比方式，以防止凭证被归属到错误的用户。对比信息包括户姓名/证件号等。可选PLAIN/MD5
        /// </summary>
        [XmlElement("apply_info_verify_mode")]
        public string ApplyInfoVerifyMode { get; set; }

        /// <summary>
        /// 用户领取的凭证唯一ID（由机构生成表达唯一性的标识，同一自然人多次申领时要求该ID唯一且幂等相同）
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 凭证实例标识（标识某个具体的凭证类型，比如上海身份码，该字段值由支付宝分配）
        /// </summary>
        [XmlElement("certificate_instance_code")]
        public string CertificateInstanceCode { get; set; }

        /// <summary>
        /// 拓展字段，JSON格式
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 凭证状态（用于控制该凭证是否在用户证件夹是否可见，T-展示，F-不展示）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 接口调用权限token，由支付宝侧下发，需携带相应token才可调用成功。 当用户从证件夹进入时，该参数通过跳转的url链接参数alipayKbCertSyncToken携带。如alipays://platformapi/startapp?appId=2021001169888888&page=pages/windowService/index/index&query=ac%3DaddCard%26alipayKbCertSyncToken%3D12345678 当用户从其他渠道进入且需要在证件夹展示该证件时，那么通过在小程序引入以下插件来进行获取 https://open.alipay.com/plugin/order-page?serviceCode=MP2021083100100571 
        /// </summary>
        [XmlElement("sync_token")]
        public string SyncToken { get; set; }

        /// <summary>
        /// 证件号，当前仅支持身份证号（用于已领取卡面脱敏展示）。在PLAIN模式下需传入证件号明文；MD5模式下需传入证件号MD5摘要
        /// </summary>
        [XmlElement("user_apply_cert_no")]
        public string UserApplyCertNo { get; set; }

        /// <summary>
        /// 展示的证件类型，由支付宝分配，当前仅支持身份证（IDENTITY_CARD）
        /// </summary>
        [XmlElement("user_apply_cert_type")]
        public string UserApplyCertType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，可以通过https://opendocs.alipay.com/apis/api_2/alipay.user.info.share 接口进行获取
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名（用于已领取卡面脱敏展示）。在PLAIN模式下需传入姓名明文；MD5模式下需传入姓名MD5摘要
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
