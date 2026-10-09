using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppBillkeySubscribeNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppBillkeySubscribeNotifyModel : AopObject
    {
        /// <summary>
        /// 支付宝户号上报流水，户号订阅表的数据库id
        /// </summary>
        [XmlElement("alipay_join_no")]
        public string AlipayJoinNo { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("billkey")]
        public string Billkey { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 户号上报机构确认流水
        /// </summary>
        [XmlElement("inst_join_no")]
        public string InstJoinNo { get; set; }

        /// <summary>
        /// 户号不能参与的原因
        /// </summary>
        [XmlElement("join_fail_reason")]
        public string JoinFailReason { get; set; }

        /// <summary>
        /// 0-不可参与 1-可参与
        /// </summary>
        [XmlElement("join_result")]
        public string JoinResult { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }
    }
}
