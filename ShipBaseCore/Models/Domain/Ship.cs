using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipBaseCore.Models.Domain
{
    [Table("ship")]
    public partial class Ship
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(7)]
        public string ID { get; set; }

        [StringLength(34)]
        public string ACCOMODATION { get; set; }

        [StringLength(34)]
        public string BALLAST { get; set; }

        [StringLength(12)]
        public string BOOKS { get; set; }

        [StringLength(34)]
        public string BUILD_INFO_1 { get; set; }

        [StringLength(34)]
        public string BUILD_INFO_2 { get; set; }

        [StringLength(12)]
        public string BUILD_NR { get; set; }

        [StringLength(10)]
        public string BLD_YARD_ID { get; set; }

        public short? BUILT_YEAR { get; set; }

        [StringLength(1)]
        public string BULB { get; set; }

        [StringLength(10)]
        public string CALLSIGN { get; set; }

        [StringLength(25)]
        public string CATEGORY { get; set; }

        [StringLength(34)]
        public string CLASS_1 { get; set; }

        [StringLength(34)]
        public string CLASS_2 { get; set; }

        [StringLength(34)]
        public string CLASS_3 { get; set; }

        [StringLength(10)]
        public string CLASS_ICE { get; set; }

        [StringLength(34)]
        public string COMM_1 { get; set; }

        [StringLength(34)]
        public string COMM_2 { get; set; }

        [StringLength(34)]
        public string DIESEL_OIL { get; set; }

        [StringLength(25)]
        public string DISPLACEMENT { get; set; }

        public int? ENGINE_BHP { get; set; }

        public int? ENGINE_KW { get; set; }

        [StringLength(5)]
        public string HULL { get; set; }

        [StringLength(5)]
        public string HULL_TYPE { get; set; }

        [StringLength(10)]
        public string AREA_ID { get; set; }

        public int? MERKE_NR { get; set; }

        [StringLength(50)]
        public string NAME { get; set; }

        [StringLength(3)]
        public string NATION_ID { get; set; }

        [StringLength(10)]
        public string NAVY_NUMBER { get; set; }

        [StringLength(10)]
        public string OFF_NUMBER { get; set; }

        [StringLength(34)]
        public string OIL { get; set; }

        [StringLength(25)]
        public string PORT { get; set; }

        [StringLength(8)]
        public string REG_NUMBER { get; set; }

        [StringLength(3)]
        public string REGISTER { get; set; }

        [StringLength(20)]
        public string SISTER_WSL { get; set; }

        [StringLength(34)]
        public string SPEED_CONS_1 { get; set; }

        [StringLength(34)]
        public string SPEED_CONS_2 { get; set; }

        public double? SPEED_KNOTS { get; set; }

        [StringLength(25)]
        public string TYPE { get; set; }

        [StringLength(34)]
        public string WATER { get; set; }

        public int? BALE_CUF { get; set; }

        public double? BALE_CUM { get; set; }

        public double? BPULL_AFT { get; set; }

        public double? BPULL_CONT { get; set; }

        public int? BPULL_MAX { get; set; }

        public short? CARS { get; set; }

        public double? CC_METRIC { get; set; }

        public double? CLEAR_DEPTH { get; set; }

        public short? CONT_TEU { get; set; }

        public short? CONT_TEU_14T { get; set; }

        public short? CONT_TEU_FRZ { get; set; }

        public short? CONT_FEU { get; set; }

        public short? CONT_TEU_HO { get; set; }

        public short? CONT_TEU_DK { get; set; }

        public short? CONT_FEU_HO { get; set; }

        public short? CONT_FEU_DK { get; set; }

        public short? CONT_TEU_ADD { get; set; }

        public short? TEU_ADD_HO { get; set; }

        public short? TEU_ADD_DK { get; set; }

        public short? DECK { get; set; }

        public double? DK_AREA { get; set; }

        public double? DK_BR { get; set; }

        public double? DK_LENGTH { get; set; }

        public int? DK_CARGO { get; set; }

        public double? DK_MAXPRESS { get; set; }

        public int? GRAIN_CUF { get; set; }

        public double? GRAIN_CUM { get; set; }

        public short? HATCH { get; set; }

        public short? HOLD { get; set; }

        public double? LANE_METERS { get; set; }

        public double? LIQUID { get; set; }

        public short? PASSANGERS { get; set; }

        public short? SURVIVORS { get; set; }

        public double? REF_CAP { get; set; }

        public short? TANK { get; set; }

        public short? TRAILERS { get; set; }

        public double? GROSS { get; set; }

        public double? GT { get; set; }

        public double? NT { get; set; }

        public double? GRT_1 { get; set; }

        public double? GRT_2 { get; set; }

        public double? NRT_1 { get; set; }

        public double? NRT_2 { get; set; }

        public double? MDWT_1 { get; set; }

        public int? MDWT_2 { get; set; }

        public double? LOA { get; set; }

        public double? LOA_DK { get; set; }

        public double? LOA_FT { get; set; }

        [StringLength(1)]
        public string LOA_X { get; set; }

        public double? LPP { get; set; }

        public double? DEPTH_1 { get; set; }

        public double? DEPTH_2 { get; set; }

        public double? DEPTH_FT_1 { get; set; }

        public double? DEPTH_FT_2 { get; set; }

        public double? BR_MOULDED { get; set; }

        public double? BR_MOULD_FT { get; set; }

        public double? BR_EXTREME { get; set; }

        public double? BR_DECK { get; set; }

        [StringLength(1)]
        public string BR_X { get; set; }

        public double? DRAUGHT_1 { get; set; }

        public double? DRAUGHT_2 { get; set; }

        public double? DRAUGHT_FT_1 { get; set; }

        public double? DRAUGHT_FT_2 { get; set; }

        public double? AIRDRAUGHT_1 { get; set; }

        public double? AIRDRAUGHT_2 { get; set; }

        public double? DRAUGHT_DRIL { get; set; }

        public double? DRAUGHT_TRAN { get; set; }

        [StringLength(25)]
        public string CHANGES { get; set; }

        [StringLength(20)]
        public string CREW_NATION { get; set; }

        [StringLength(15)]
        public string CREW_NUMBER { get; set; }

        [StringLength(25)]
        public string EXNAME { get; set; }

        [StringLength(30)]
        public string INFO_SOURCE { get; set; }

        [StringLength(1)]
        public string INFO_STATUS { get; set; }

        [StringLength(8)]
        public string LETTER_DATE { get; set; }

        public short? DRAWING_ID { get; set; }

        [StringLength(1)]
        public string DRAW_STATUS { get; set; }

        [StringLength(8)]
        public string PHOTO_ID { get; set; }

        [StringLength(8)]
        public string PHOTO2_ID { get; set; }

        [StringLength(1)]
        public string PHOTO_STATUS { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? PHOTO_DATE { get; set; }

        [StringLength(3)]
        public string PHOTOGRA_ID { get; set; }

        [StringLength(3)]
        public string PHOTOGRA2_ID { get; set; }

        [StringLength(40)]
        public string POSITION { get; set; }

        [StringLength(5)]
        public string CASTROLKATEGORI { get; set; }

        public int? TOTALFORBRUKSMOROLJE { get; set; }

        [StringLength(1)]
        public string MERKE { get; set; }

        public int? ONR { get; set; }

        [StringLength(30)]
        public string POSISION { get; set; }

        [StringLength(15)]
        public string MMSINR { get; set; }

        [StringLength(7)]
        public string IMONO { get; set; }

        public byte? BLD_MONTH { get; set; }

        public byte? BLD_DAY { get; set; }

        [StringLength(10)]
        public string SEC_YARD { get; set; }

        public double? LENGTH_REG { get; set; }

        [StringLength(20)]
        public string LASTCLASS_YEAR { get; set; }

        [StringLength(20)]
        public string NEXT_CLASS_YEAR { get; set; }

        [StringLength(6)]
        public string PORT_ID { get; set; }

        [StringLength(3)]
        public string PORT_NATION { get; set; }

        [StringLength(3)]
        public string OPORT_NATION { get; set; }

        [StringLength(6)]
        public string OPORT_ID { get; set; }

        [StringLength(40)]
        public string OPPORT { get; set; }

        [StringLength(4)]
        public string BOKFORMAT { get; set; }

        [StringLength(64)]
        public string WEBSIDE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DRAWING_DATE { get; set; }

        [StringLength(12)]
        public string HULL_BUILT_NO { get; set; }

        [StringLength(50)]
        public string INT_NAME { get; set; }

        public double? MAX_LIFT { get; set; }

        [StringLength(45)]
        public string M_LIFT_DESC { get; set; }

        public double? LENGHT_WATERLINE { get; set; }

        [StringLength(30)]
        public string PLACE_OF_BUILT { get; set; }

        [StringLength(30)]
        public string NATION_OF_BUILT { get; set; }

        [StringLength(1)]
        public string WEBPUB_DESIGNER { get; set; }

        [StringLength(1)]
        public string WEBPUB_YARDS { get; set; }

        [StringLength(1)]
        public string WEBPUB_VESSEL { get; set; }

        [StringLength(1)]
        public string WEBPUB_OWNER { get; set; }

        [StringLength(20)]
        public string INT_NBR { get; set; }

        [StringLength(10)]
        public string EC_CODE { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? BUILT_DATE { get; set; }

        public int? FIRST_REG { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CHANGE_DATE { get; set; }

        [StringLength(12)]
        public string ISPS_NO { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ISPS_NO_DATE_FROM { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ISPS_NO_DATE_TO { get; set; }

        [StringLength(1)]
        public string FRAKYSTVERK { get; set; }

        [StringLength(20)]
        public string IOTC_NO { get; set; }

        [StringLength(30)]
        public string MIDLERTIDIG_FISHID { get; set; }

        [Column(Order = 1, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
