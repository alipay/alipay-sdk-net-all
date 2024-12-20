using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentPayContractInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentPayContractInfo : AopObject
    {
        /// <summary>
        /// 本次提取所属结束月，格式yyyy-mm
        /// </summary>
        [XmlElement("draw_end_month")]
        public string DrawEndMonth { get; set; }

        /// <summary>
        /// 本次提取所属开始月，格式yyyy-mm
        /// </summary>
        [XmlElement("draw_starting_month")]
        public string DrawStartingMonth { get; set; }

        /// <summary>
        /// 租约提取截止月
        /// </summary>
        [XmlElement("project_closing_month")]
        public string ProjectClosingMonth { get; set; }

        /// <summary>
        /// 租房合同编号
        /// </summary>
        [XmlElement("rent_contract_no")]
        public string RentContractNo { get; set; }

        /// <summary>
        /// 房屋具体地址
        /// </summary>
        [XmlElement("rent_house_address")]
        public string RentHouseAddress { get; set; }

        /// <summary>
        /// 合同结束日期，格式yyyy-mm-dd
        /// </summary>
        [XmlElement("rent_pay_end_time")]
        public string RentPayEndTime { get; set; }

        /// <summary>
        /// 合同开始日期，格式yyyy-mm-dd
        /// </summary>
        [XmlElement("rent_pay_start_time")]
        public string RentPayStartTime { get; set; }

        /// <summary>
        /// 租房项目编号
        /// </summary>
        [XmlElement("rent_project_no")]
        public string RentProjectNo { get; set; }
    }
}
