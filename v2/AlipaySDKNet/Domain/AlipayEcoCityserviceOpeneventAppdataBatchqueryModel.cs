using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceOpeneventAppdataBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoCityserviceOpeneventAppdataBatchqueryModel : AopObject
    {
        /// <summary>
        /// 行业编码，一网通办机构传 CITYSERVICE
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 格式为 yyyy-MM-dd 的字符串
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// day | week | month 选择一个传入；day 表示取当天数据，week表示取当天向前7天内的汇总数据；month表示取当前向前30天内的汇总数据
        /// </summary>
        [XmlElement("date_type")]
        public string DateType { get; set; }

        /// <summary>
        /// 分页时，当前页码。起始值为1
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页时，每页的大小。最大值为100，最小值为1
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 要查询的数据看版类型标识
        /// </summary>
        [XmlElement("panel_type")]
        public string PanelType { get; set; }
    }
}
