using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotGroupMemberBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotGroupMemberBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 分组成员列表
        /// </summary>
        [XmlArray("members")]
        [XmlArrayItem("device_group_member")]
        public List<DeviceGroupMember> Members { get; set; }

        /// <summary>
        /// 分组中的设备总数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
