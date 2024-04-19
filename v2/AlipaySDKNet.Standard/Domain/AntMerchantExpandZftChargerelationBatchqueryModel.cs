using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandZftChargerelationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandZftChargerelationBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询维度，默认dimension=PRIMARY;
        /// </summary>
        [XmlElement("dimension")]
        public string Dimension { get; set; }

        /// <summary>
        /// 分页页码，默认page_num=1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页返回数量，默认page_size=10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 对象目标ID，可为关联主ID，也可为关联子ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }
    }
}
