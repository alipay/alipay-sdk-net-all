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
        /// 含义：申领信息核验模式，该字段用于控制传入的信息与支付宝侧信息的核验对比方式，以防止凭证被归属到错误的用户。对比信息包括姓名/证件号等。  如何设置： 【身份码】请填写 PLAIN 【非身份码】不传或留空
        /// </summary>
        [XmlElement("apply_info_verify_mode")]
        public string ApplyInfoVerifyMode { get; set; }

        /// <summary>
        /// 含义：凭证ID，同一自然人同一凭证多次申领时要求该ID唯一且幂等相同。  如何设置： 【身份码】：用于系统内唯一性标示，由机构确定，若无合适值也可使用user_id；  【非身份码】：凭证号，除用于唯一性标示外还被用于页面展示，由机构确定
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 含义：凭证实例标识（标识某个具体的凭证类型，比如上海身份码） 如何设置：由支付宝分配固定值
        /// </summary>
        [XmlElement("certificate_instance_code")]
        public string CertificateInstanceCode { get; set; }

        /// <summary>
        /// 含义：拓展字段，JSON格式 如何设置： 【身份码】不传  【非身份码】格式为Map<String，String>的JSON，如：{"ext_info":{"address":"XXXXXX"}}，根据证件类型的不同，Map的Key有所区别，具体字段咨询支付宝证件夹技术。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 含义：支付宝用户的openId，是用户（userId）在应用（AppId）下的唯一用户标识（新接入的ISV必传open_id，不传user_id）。网关会将传入的open_id字段的值转换为user_id（2088格式），并放入与之映射的原user_id字段，并移除open_id参数，业务系统获取到的参数仅有user_id。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 含义：凭证状态（用于控制该凭证是否在用户证件夹是否可见） 如何设置： T：展示凭证，当用户从卡包点击待领取跳转领取成功（无论是否首次，凡是识别到是卡包领取链接过来的）或者从其他渠道领取成功且需要同步到卡包时，需要传送该值。 F：不展示，当用户在机构页面将凭证删除时，需要传送该值。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 含义：接口调用权限token，由支付宝侧下发，需携带相应token才可调用成功。  如何设置： 【身份码】 1，当用户从证件夹跳转领取时，该参数通过跳转的url链接参数alipayKbCertSyncToken携带，如：alipays://platformapi/startapp?appId=2021001169888888&page=pages/windowService/index/index&query=ac%3DaddCard%26alipayKbCertSyncToken%3D12345678  2，当用户不是从证件夹跳转领取但需要在证件夹展示该证件时，需要通过在小程序引入以下插件获取token： https://open.alipay.com/plugin/order-page?serviceCode=MP2021083100100571 【非身份码】 1，当用户从证件夹跳转领取时，传空或不传 2，当用户不是从证件夹跳转领取但需要在证件夹展示该证件时，通过在小程序引入以下插件获取token： https://open.alipay.com/plugin/order-page?serviceCode=MP2021083100100571
        /// </summary>
        [XmlElement("sync_token")]
        public string SyncToken { get; set; }

        /// <summary>
        /// 含义：用户申领时使用的证件号（用于已领取卡面脱敏展示及信息校验）  如何设置： 【身份码】传身份证号 【非身份码】不传或留空（其展示功能被certificate_id所代替）
        /// </summary>
        [XmlElement("user_apply_cert_no")]
        public string UserApplyCertNo { get; set; }

        /// <summary>
        /// 含义：用户申领时使用的证件类型，由支付宝分配。 如何设置：  【身份码】：请填写 IDENTITY_CARD  【非身份码】：不传或留空
        /// </summary>
        [XmlElement("user_apply_cert_type")]
        public string UserApplyCertType { get; set; }

        /// <summary>
        /// 含义：蚂蚁统一会员ID（以2088开头） 如何设置：获取方式多样，一种获取方式是通过https://opendocs.alipay.com/apis/api_2/alipay.user.info.share 接口进行获取
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 含义：名称（用于已领取卡面脱敏展示及凭证信息校验） 如何设置： 【身份码】用户姓名 【非身份码】视证件类型而定，一般为用户姓名或证件持有方名称
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
