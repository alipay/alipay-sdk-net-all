using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageItempackageinstanceQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageItempackageinstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 单项资源包实例详情列表
        /// </summary>
        [XmlArray("item_package_instances")]
        [XmlArrayItem("item_package_instance")]
        public List<ItemPackageInstance> ItemPackageInstances { get; set; }
    }
}
