using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationIsvServiceSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationIsvServiceSubmitModel : AopObject
    {
        /// <summary>
        /// 扩展字段，服务扩展字段，示例：key：service_levle，value：standard
        /// </summary>
        [XmlArray("extra_info")]
        [XmlArrayItem("extra_info")]
        public List<ExtraInfo> ExtraInfo { get; set; }

        /// <summary>
        /// 商户信息
        /// </summary>
        [XmlElement("merchant_info")]
        public CateringMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 服务营业时间(与门店营业时间二选一必填),示例：[{"business_time":[{"start_time":"10:00","end_time":"14:00"},{"start_time":"16:00","end_time":"20:00"}],"business_date":["周一","周二"]},{"business_time":[{"start_time":"08:00","end_time":"22:00"}],"business_date":["周三","周四","周五"]},{"business_time":[{"start_time":"08:00","end_time":"23:00"}],"business_date":["周六","周日"]}]
        /// </summary>
        [XmlArray("service_business_hours")]
        [XmlArrayItem("service_business_hours")]
        public List<ServiceBusinessHours> ServiceBusinessHours { get; set; }

        /// <summary>
        /// 描述此服务的内容
        /// </summary>
        [XmlElement("service_description")]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// 服务名称（针对此服务类型有特殊的品牌宣导，如肯德基宅急送；如没有特殊要求，可不填）；长度最大15个中文字符
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务范围信息
        /// </summary>
        [XmlElement("service_scope_info")]
        public CateringServiceScopeInfo ServiceScopeInfo { get; set; }

        /// <summary>
        /// 服务状态（ServiceStatus枚举） SERVICE_CREATE：服务创建 SERVICE_UPDATE：服务更新 SERVICE_OFFLINE：服务下线
        /// </summary>
        [XmlElement("service_status")]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 服务子类型（ServiceSubType枚举） 自提:PICK_UP 外卖:TAKE_AWAY 排队:QUEUE
        /// </summary>
        [XmlElement("service_sub_type")]
        public string ServiceSubType { get; set; }

        /// <summary>
        /// 服务类型（餐饮固定为CATERING，ServiceType枚举）
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务url（请注意：1、可直接跳转对应的服务子类型小程序页面；2、url当中的小程序需要和开放平台解析出的小程序appid一致）
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("store_info")]
        public CateringStoreInfo StoreInfo { get; set; }
    }
}
