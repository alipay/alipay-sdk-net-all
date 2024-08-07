using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdMaterialUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdMaterialUploadModel : AopObject
    {
        /// <summary>
        /// SUBSCRIPT_COMMON-角标专用 SIX_ONE_EIGHT_TINYAPP-品牌普通链接  PROMOTE_PAGE-留资推广页(免费留资版) PAID_PROMOTE_PAGE-留资推广页(付费留资) BRAND_APP_COMMON_WAKE_UP_REGIS-品牌通用唤端 BRAND_APP_DOWNLOAD-品牌APP下载 等等
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 交易ID（灯火平台生成，请联系灯火运营获取）
        /// </summary>
        [XmlElement("deal_id")]
        public string DealId { get; set; }

        /// <summary>
        /// FEI_ZHU(5,"飞猪") TAO_PIAO_PIAO(6,"淘票票") ELEME(7,"饿了么") MA_YI_BAO(8,"蚂蚁保") JIANG_XING(9,"将行"); MI_MAN(10,"米漫"), TAI_ZHI_PU(11,"泰之菩"); 等等
        /// </summary>
        [XmlElement("deal_type")]
        public string DealType { get; set; }

        /// <summary>
        /// 上传图片/视频物料对应的外部id，需要保证唯一
        /// </summary>
        [XmlElement("material_outer_id")]
        public string MaterialOuterId { get; set; }

        /// <summary>
        /// 物料元素
        /// </summary>
        [XmlElement("material_unit")]
        public UploadMaterial MaterialUnit { get; set; }

        /// <summary>
        /// 创意关联模板ID，由投放平台管理生成
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// CREATIVE-创意物料 ACTION-交互动作物料
        /// </summary>
        [XmlElement("upload_type")]
        public string UploadType { get; set; }
    }
}
