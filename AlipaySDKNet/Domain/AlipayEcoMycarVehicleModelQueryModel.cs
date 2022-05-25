using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoMycarVehicleModelQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarVehicleModelQueryModel : AopObject
    {
        /// <summary>
        /// 查询结束时间，开区间，格式为「yyyy-MM-dd HH:mm:ss」，不传默认当前时间
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 页数，最小1、最大10000，不传默认为1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，最小1、最大200，不传默认200
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询起始时间，闭区间，格式为「yyyy-MM-dd HH:mm:ss」
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
