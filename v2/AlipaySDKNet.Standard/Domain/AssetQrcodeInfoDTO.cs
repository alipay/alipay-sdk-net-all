using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetQrcodeInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AssetQrcodeInfoDTO : AopObject
    {
        /// <summary>
        /// 新空码绑码时关联的AO申请单号
        /// </summary>
        [XmlElement("bind_apply_order_id")]
        public string BindApplyOrderId { get; set; }

        /// <summary>
        /// 新空码绑码时关联的指令ID
        /// </summary>
        [XmlElement("bind_assign_item_id")]
        public string BindAssignItemId { get; set; }

        /// <summary>
        /// 码的业务编码，标识码的业务分类
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务主单据编号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 码的业务类型，标识码的类型分类
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 物料项ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 物料项名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// nfc 链接
        /// </summary>
        [XmlElement("nfc_url")]
        public string NfcUrl { get; set; }

        /// <summary>
        /// 码值
        /// </summary>
        [XmlElement("qrcode")]
        public string Qrcode { get; set; }

        /// <summary>
        /// 码值图片的URL地址，用于展示码值的图片资源。
        /// </summary>
        [XmlElement("qrcode_img_url")]
        public string QrcodeImgUrl { get; set; }

        /// <summary>
        /// 码值URL
        /// </summary>
        [XmlElement("qrcode_url")]
        public string QrcodeUrl { get; set; }

        /// <summary>
        /// 业务子单据编号
        /// </summary>
        [XmlElement("sub_biz_no")]
        public string SubBizNo { get; set; }

        /// <summary>
        /// 线圈平台物料的tagId标识，用于关联线圈平台的物料信息。
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }
    }
}
