using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcBalanceIsvQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcBalanceIsvQueryModel : AopObject
    {
        /// <summary>
        /// 账单时间： 日账单格式为yyyy-MM-dd，最早可下载2016年1月1日开始的日账单。不支持下载当日账单，只能下载前一日24点前的账单数据（T+1），当日数据一般于次日 9 点前生成，特殊情况可能延迟。
        /// </summary>
        [XmlElement("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型，支持： enterprisetrade：商户基于企业码交易收单的业务账单;
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }
    }
}
