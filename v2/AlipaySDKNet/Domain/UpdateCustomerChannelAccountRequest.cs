using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UpdateCustomerChannelAccountRequest Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateCustomerChannelAccountRequest : AopObject
    {
        /// <summary>
        /// 绑定状态，目前只支持更新为已绑定
        /// </summary>
        [XmlElement("binding_status")]
        public string BindingStatus { get; set; }

        /// <summary>
        /// 表示是否删除该记录
        /// </summary>
        [XmlElement("delete_flag")]
        public bool DeleteFlag { get; set; }

        /// <summary>
        /// 海图主键ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
