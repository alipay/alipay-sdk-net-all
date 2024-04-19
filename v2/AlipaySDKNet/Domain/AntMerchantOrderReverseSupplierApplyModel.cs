using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantOrderReverseSupplierApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantOrderReverseSupplierApplyModel : AopObject
    {
        /// <summary>
        /// 供应商逆向申请明细
        /// </summary>
        [XmlElement("asset_reverse_supplier_apply_detail")]
        public AssetReverseSupplierApplyDetail AssetReverseSupplierApplyDetail { get; set; }
    }
}
