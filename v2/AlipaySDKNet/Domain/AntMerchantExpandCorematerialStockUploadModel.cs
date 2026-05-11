using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandCorematerialStockUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandCorematerialStockUploadModel : AopObject
    {
        /// <summary>
        /// 库存信息
        /// </summary>
        [XmlArray("stock_data_list")]
        [XmlArrayItem("core_material_stock_data")]
        public List<CoreMaterialStockData> StockDataList { get; set; }

        /// <summary>
        /// 出入库明细信息
        /// </summary>
        [XmlArray("stock_detail_list")]
        [XmlArrayItem("core_material_stock_detail")]
        public List<CoreMaterialStockDetail> StockDetailList { get; set; }

        /// <summary>
        /// 批次号，用于幂等
        /// </summary>
        [XmlElement("upload_batch_no")]
        public string UploadBatchNo { get; set; }

        /// <summary>
        /// 上传类型：STOCK_COUNT-库存数量（覆盖式更新）/STOCK_DETAIL-出入库明细
        /// </summary>
        [XmlElement("upload_type")]
        public string UploadType { get; set; }
    }
}
