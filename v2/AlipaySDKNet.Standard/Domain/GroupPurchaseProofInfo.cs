using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPurchaseProofInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPurchaseProofInfo : AopObject
    {
        /// <summary>
        /// 授权材料图片，使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("appeal_letter_url")]
        public string AppealLetterUrl { get; set; }

        /// <summary>
        /// 租赁合同图片，使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("lease_contract_url")]
        public string LeaseContractUrl { get; set; }

        /// <summary>
        /// 产权证明图片，使用openApi接口ant.merchant.expand.indirect.image.upload 接口上传图片后得到的 image_id。文件最小为 5KB，最大为5M，图片格式必须为：png、jpg、jpeg。
        /// </summary>
        [XmlElement("property_ownership_proof_url")]
        public string PropertyOwnershipProofUrl { get; set; }
    }
}
