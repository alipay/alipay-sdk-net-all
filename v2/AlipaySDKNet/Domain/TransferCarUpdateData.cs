using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferCarUpdateData Data Structure.
    /// </summary>
    [Serializable]
    public class TransferCarUpdateData : AopObject
    {
        /// <summary>
        /// 商户数据修改的时间，商户数据发生变化，该值必须更新，单位时间戳
        /// </summary>
        [XmlElement("isv_update_date")]
        public string IsvUpdateDate { get; set; }

        /// <summary>
        /// 车源 id值，第三方车源 id 数据，第三方商户传递的 id 值
        /// </summary>
        [XmlElement("out_id")]
        public string OutId { get; set; }

        /// <summary>
        /// 车价格；单位分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 状态，1 上架， 2 下架
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
