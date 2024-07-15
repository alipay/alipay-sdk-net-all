using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseProfilesDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseProfilesDTO : AopObject
    {
        /// <summary>
        /// 是否需创建企业人脸库，适用于对接团餐刷脸付、门禁刷脸通行等场景；不传默认为 false，传 true 时会自动创建 IOT 设备企业人脸库，人脸库创建失败会阻塞企业的创建。
        /// </summary>
        [XmlElement("create_iot_group")]
        public bool CreateIotGroup { get; set; }

        /// <summary>
        /// 用于区分资金因公付协议、以及收银台文案等差异；不传默认为ISV_QYM。
        /// </summary>
        [XmlElement("fund_biz_scene")]
        public string FundBizScene { get; set; }

        /// <summary>
        /// 订购支付宝「一脸通行开通插件」的小程序appId
        /// </summary>
        [XmlElement("group_app_id")]
        public string GroupAppId { get; set; }
    }
}
