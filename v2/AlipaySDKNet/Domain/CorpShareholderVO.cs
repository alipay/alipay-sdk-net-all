using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CorpShareholderVO Data Structure.
    /// </summary>
    [Serializable]
    public class CorpShareholderVO : AopObject
    {
        /// <summary>
        /// 出资时间
        /// </summary>
        [XmlElement("divestment_date")]
        public string DivestmentDate { get; set; }

        /// <summary>
        /// 入股时间
        /// </summary>
        [XmlElement("shareholder_date")]
        public string ShareholderDate { get; set; }

        /// <summary>
        /// 股东名称
        /// </summary>
        [XmlElement("shareholder_name")]
        public string ShareholderName { get; set; }

        /// <summary>
        /// 持股列表
        /// </summary>
        [XmlArray("totals")]
        [XmlArrayItem("corp_shareholder_total")]
        public List<CorpShareholderTotal> Totals { get; set; }

        /// <summary>
        /// 转股时间
        /// </summary>
        [XmlElement("transfer_date")]
        public string TransferDate { get; set; }
    }
}
