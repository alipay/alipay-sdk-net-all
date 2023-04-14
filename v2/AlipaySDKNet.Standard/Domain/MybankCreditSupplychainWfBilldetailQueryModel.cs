using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfBilldetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfBilldetailQueryModel : AopObject
    {
        /// <summary>
        /// 首次入账结束时间
        /// </summary>
        [XmlElement("maxstartdate")]
        public long Maxstartdate { get; set; }

        /// <summary>
        /// 首次入账起始时间
        /// </summary>
        [XmlElement("minstartdate")]
        public long Minstartdate { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("pagenum")]
        public long Pagenum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("pagesize")]
        public string Pagesize { get; set; }

        /// <summary>
        /// 固定，WF提前收款个人
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        [XmlElement("sellerid")]
        public string Sellerid { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [XmlElement("siteuserid")]
        public string Siteuserid { get; set; }

        /// <summary>
        /// 账单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
