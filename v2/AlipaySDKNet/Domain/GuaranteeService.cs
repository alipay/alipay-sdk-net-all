using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GuaranteeService Data Structure.
    /// </summary>
    [Serializable]
    public class GuaranteeService : AopObject
    {
        /// <summary>
        /// 垫付保障
        /// </summary>
        [XmlElement("advance_payment_guarantee")]
        public GuaranteeDetail AdvancePaymentGuarantee { get; set; }

        /// <summary>
        /// 保障服务的价格，单位分。注意这里是总价，不是单价，也就是说在当前租期、车型下，用户购买此保障服务需要额外支付的金额
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 折旧费保障
        /// </summary>
        [XmlElement("depreciation_guarantee")]
        public GuaranteeDetail DepreciationGuarantee { get; set; }

        /// <summary>
        /// 保障服务的名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 乘客保障
        /// </summary>
        [XmlElement("passenger_guarantee")]
        public GuaranteeDetail PassengerGuarantee { get; set; }

        /// <summary>
        /// 保障服务的简介。用户在费用明细中给用户展示服务简介。
        /// </summary>
        [XmlElement("service_description")]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// 需要用户承担的服务明细
        /// </summary>
        [XmlArray("service_exclude_detail")]
        [XmlArrayItem("string")]
        public List<string> ServiceExcludeDetail { get; set; }

        /// <summary>
        /// 保障服务提供的不需用户承担的服务明细
        /// </summary>
        [XmlArray("service_include_detail")]
        [XmlArrayItem("string")]
        public List<string> ServiceIncludeDetail { get; set; }

        /// <summary>
        /// 停运费保障
        /// </summary>
        [XmlElement("stop_business_guarantee")]
        public GuaranteeDetail StopBusinessGuarantee { get; set; }

        /// <summary>
        /// 用户展示补充说明的附图
        /// </summary>
        [XmlElement("supplementary_img")]
        public string SupplementaryImg { get; set; }

        /// <summary>
        /// 三者保障
        /// </summary>
        [XmlElement("third_party_guarantee")]
        public GuaranteeDetail ThirdPartyGuarantee { get; set; }

        /// <summary>
        /// 保障服务唯一标识
        /// </summary>
        [XmlElement("unique_code")]
        public string UniqueCode { get; set; }

        /// <summary>
        /// 车损保障
        /// </summary>
        [XmlElement("vehicle_damage_guarantee")]
        public GuaranteeDetail VehicleDamageGuarantee { get; set; }
    }
}
