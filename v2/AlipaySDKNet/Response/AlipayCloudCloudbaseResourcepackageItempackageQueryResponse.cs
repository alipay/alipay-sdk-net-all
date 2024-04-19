using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageItempackageQueryResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageItempackageQueryResponse : AopResponse
    {
        /// <summary>
        /// 单项资源包列表信息
        /// </summary>
        [XmlArray("item_package_list")]
        [XmlArrayItem("item_package")]
        public List<ItemPackage> ItemPackageList { get; set; }
    }
}
