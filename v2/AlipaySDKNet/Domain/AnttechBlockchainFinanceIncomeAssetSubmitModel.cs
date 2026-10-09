using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceIncomeAssetSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceIncomeAssetSubmitModel : AopObject
    {
        /// <summary>
        /// 实物资产对应的外部编号，如设备号号码
        /// </summary>
        [XmlElement("asset_out_no")]
        public string AssetOutNo { get; set; }

        /// <summary>
        /// 资产登记流水号，用于幂等校验
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 设备类型，根据实际设备类型填写
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 收益分配产品码，可联系产品或运营同学获取
        /// </summary>
        [XmlElement("distribution_pro_no")]
        public string DistributionProNo { get; set; }

        /// <summary>
        /// 实物品牌，按照实际资产设备品牌填写
        /// </summary>
        [XmlElement("material_brand")]
        public string MaterialBrand { get; set; }

        /// <summary>
        /// 实物型号，按照实际资产设备型号填写
        /// </summary>
        [XmlElement("material_model_no")]
        public string MaterialModelNo { get; set; }

        /// <summary>
        /// 实物的实际生产时间，时间格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("produce_date")]
        public string ProduceDate { get; set; }

        /// <summary>
        /// 权属材料文件ID，请按照文件上传返回的fileId提供
        /// </summary>
        [XmlElement("prove_file_id")]
        public string ProveFileId { get; set; }

        /// <summary>
        /// 相关方列表
        /// </summary>
        [XmlArray("related_parties")]
        [XmlArrayItem("related_parties")]
        public List<RelatedParties> RelatedParties { get; set; }
    }
}
