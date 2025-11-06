using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNcoilopenOrderQueryResponse.
    /// </summary>
    public class AlipayOpenSpNcoilopenOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 实际发货时间
        /// </summary>
        [XmlElement("actual_delivery_time")]
        public string ActualDeliveryTime { get; set; }

        /// <summary>
        /// 创建申请单的时候的描述信息
        /// </summary>
        [XmlElement("apply_describe")]
        public string ApplyDescribe { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        [XmlElement("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("biz_scene_code")]
        public string BizSceneCode { get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [XmlElement("biz_scene_resource_id")]
        public string BizSceneResourceId { get; set; }

        /// <summary>
        /// 物料excel文件url
        /// </summary>
        [XmlElement("download_materials_excel_url")]
        public string DownloadMaterialsExcelUrl { get; set; }

        /// <summary>
        /// 预计交货时间
        /// </summary>
        [XmlElement("estimated_delivery_time")]
        public string EstimatedDeliveryTime { get; set; }

        /// <summary>
        /// 预计交付门店数
        /// </summary>
        [XmlElement("estimated_shop_sum")]
        public string EstimatedShopSum { get; set; }

        /// <summary>
        /// 期望发货时间
        /// </summary>
        [XmlElement("expected_delivery_time")]
        public string ExpectedDeliveryTime { get; set; }

        /// <summary>
        /// excel文件fileId
        /// </summary>
        [XmlElement("materials_excel_file_id")]
        public string MaterialsExcelFileId { get; set; }

        /// <summary>
        /// 物料中枢
        /// </summary>
        [XmlElement("materials_total")]
        public long MaterialsTotal { get; set; }

        /// <summary>
        /// 如果订单已经送产，会有生产单号
        /// </summary>
        [XmlElement("production_order_no")]
        public string ProductionOrderNo { get; set; }

        /// <summary>
        /// 如果审批单被撤销了，会填写撤销原因
        /// </summary>
        [XmlElement("revoke_reason")]
        public string RevokeReason { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 供应商id
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
