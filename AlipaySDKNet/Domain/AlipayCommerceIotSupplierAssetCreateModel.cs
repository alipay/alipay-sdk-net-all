using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSupplierAssetCreateModel : AopObject
    {
        /// <summary>
        /// 供应商设备信息
        /// </summary>
        [XmlElement("record")]
        public SupplierAssetResponse Record { get; set; }
    }
}
