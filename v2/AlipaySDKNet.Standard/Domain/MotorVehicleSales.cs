using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MotorVehicleSales Data Structure.
    /// </summary>
    [Serializable]
    public class MotorVehicleSales : AopObject
    {
        /// <summary>
        /// 金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购方组织机构代码
        /// </summary>
        [XmlElement("buyer_org_code")]
        public string BuyerOrgCode { get; set; }

        /// <summary>
        /// 购方纳税人识别号；税号/身份证号
        /// </summary>
        [XmlElement("buyer_tax_no")]
        public string BuyerTaxNo { get; set; }

        /// <summary>
        /// 合格证号
        /// </summary>
        [XmlElement("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 发动机号码
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 厂牌型号
        /// </summary>
        [XmlElement("factory_model")]
        public string FactoryModel { get; set; }

        /// <summary>
        /// 进口证明书号
        /// </summary>
        [XmlElement("import_proof_no")]
        public string ImportProofNo { get; set; }

        /// <summary>
        /// 商检单号
        /// </summary>
        [XmlElement("inspection_no")]
        public string InspectionNo { get; set; }

        /// <summary>
        /// 机器编号
        /// </summary>
        [XmlElement("machine_no")]
        public string MachineNo { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        [XmlElement("origin_place")]
        public string OriginPlace { get; set; }

        /// <summary>
        /// 限乘人数
        /// </summary>
        [XmlElement("passenger_capacity")]
        public string PassengerCapacity { get; set; }

        /// <summary>
        /// 完税凭证号码
        /// </summary>
        [XmlElement("payment_voucher_no")]
        public string PaymentVoucherNo { get; set; }

        /// <summary>
        /// 销方账户
        /// </summary>
        [XmlElement("seller_account")]
        public string SellerAccount { get; set; }

        /// <summary>
        /// 销方地址
        /// </summary>
        [XmlElement("seller_address")]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 销方开户银行
        /// </summary>
        [XmlElement("seller_bank")]
        public string SellerBank { get; set; }

        /// <summary>
        /// 销货单位名称
        /// </summary>
        [XmlElement("seller_name")]
        public string SellerName { get; set; }

        /// <summary>
        /// 销货单位纳税人识别号
        /// </summary>
        [XmlElement("seller_tax_no")]
        public string SellerTaxNo { get; set; }

        /// <summary>
        /// 销货单位电话
        /// </summary>
        [XmlElement("seller_tel")]
        public string SellerTel { get; set; }

        /// <summary>
        /// 税额，单位：元
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 主管税务机关
        /// </summary>
        [XmlElement("tax_authority")]
        public string TaxAuthority { get; set; }

        /// <summary>
        /// 主管税务机关代码
        /// </summary>
        [XmlElement("tax_authority_code")]
        public string TaxAuthorityCode { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 吨位
        /// </summary>
        [XmlElement("tonnage")]
        public string Tonnage { get; set; }

        /// <summary>
        /// 价税合计，单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 车辆识别代号
        /// </summary>
        [XmlElement("vehicle_identification_no")]
        public string VehicleIdentificationNo { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 查验时间
        /// </summary>
        [XmlElement("verify_time")]
        public string VerifyTime { get; set; }
    }
}
