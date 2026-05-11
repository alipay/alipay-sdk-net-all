using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandCorematerialPoUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandCorematerialPoUploadModel : AopObject
    {
        /// <summary>
        /// PO明细信息
        /// </summary>
        [XmlArray("po_data_list")]
        [XmlArrayItem("core_material_po_data")]
        public List<CoreMaterialPoData> PoDataList { get; set; }

        /// <summary>
        /// 供应商ID，由蚂蚁分配
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 上传类型：NEW-新增/STATUS_CHANGE-状态变更
        /// </summary>
        [XmlElement("upload_type")]
        public string UploadType { get; set; }
    }
}
