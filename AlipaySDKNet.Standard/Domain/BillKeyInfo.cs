using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BillKeyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BillKeyInfo : AopObject
    {
        /// <summary>
        /// 户号
        /// </summary>
        [XmlElement("billkey")]
        public string Billkey { get; set; }

        /// <summary>
        /// 一级业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构
        /// </summary>
        [XmlElement("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 城市（6位code） 举例：杭州市：330100
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 区县（6位code） 举例： 西湖区 330106
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 省份（6位code） 举例：浙江省：330000
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 水费：WATER 电费：ELECTRIC 燃气费：GAS 暖气费：HEATING 有限电视：CATV 固话和宽带都是：COMMUN
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
