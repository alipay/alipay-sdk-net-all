using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIndustryServiceSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIndustryServiceSubmitModel : AopObject
    {
        /// <summary>
        /// 扩展字段，服务扩展字段，示例：key：service_sub_type，value：car_rental_day
        /// </summary>
        [XmlArray("extra_info")]
        [XmlArrayItem("extra_info")]
        public List<ExtraInfo> ExtraInfo { get; set; }

        /// <summary>
        /// 行业信息,数据格式详情联系解决方案同学
        /// </summary>
        [XmlElement("industry_info")]
        public string IndustryInfo { get; set; }

        /// <summary>
        /// 商户侧服务编码。回收行业会优先以该字段作为服务唯一键，如果没有传该字段，会用service_name作为服务唯一键。
        /// </summary>
        [XmlElement("out_service_code")]
        public string OutServiceCode { get; set; }

        /// <summary>
        /// 服务动作 SERVICE_CREATE：服务创建 SERVICE_UPDATE：服务更新
        /// </summary>
        [XmlElement("service_action")]
        public string ServiceAction { get; set; }

        /// <summary>
        /// 某某到家服务提供优质服务,提升生活品质
        /// </summary>
        [XmlElement("service_description")]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// 描述服务名称(不可重复)
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 租车固定为 CAR_RENTAL 到家服务固定为 HOME_SERVICE 上门回收固定为 DOOR_RECYCLING
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }

        /// <summary>
        /// 服务url（可直接跳转对应的服务子类型小程序页面）
        /// </summary>
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
