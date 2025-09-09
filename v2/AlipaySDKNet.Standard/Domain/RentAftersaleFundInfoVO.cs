using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentAftersaleFundInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentAftersaleFundInfoVO : AopObject
    {
        /// <summary>
        /// 费用项明细列表
        /// </summary>
        [XmlArray("fund_item_list")]
        [XmlArrayItem("rent_aftersale_fund_item_v_o")]
        public List<RentAftersaleFundItemVO> FundItemList { get; set; }

        /// <summary>
        /// 总金额，单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
