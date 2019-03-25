using ShipBaseCore.Models.Domain;

namespace ShipBaseCore.Models.Extensions
{
    public static class CompanyExtensions
    {
        public static void Map(this Company dbCompany, Company company)
        {
            dbCompany.FIRMAID = company.FIRMAID;
            dbCompany.NAME = company.NAME;
            dbCompany.CUST_NO = company.CUST_NO;
            dbCompany.ADDRESS = company.ADDRESS;
            dbCompany.OFFICE = company.OFFICE;
            dbCompany.PLACE = company.PLACE;
            dbCompany.POSTBOX_PNO = company.POSTBOX_PNO;
            dbCompany.COUNTY = company.COUNTY;
            dbCompany.TELEPHONE = company.TELEPHONE;
            dbCompany.TELEFAX = company.TELEFAX;
            dbCompany.TELEX = company.TELEX;
            dbCompany.CABLE = company.CABLE;
            dbCompany.YARD = company.YARD;
            dbCompany.FORETAKSNR = company.FORETAKSNR;
            dbCompany.LABEL_COUNT = company.LABEL_COUNT;
            dbCompany.NATION_ID = company.NATION_ID;
            dbCompany.PLACE_ID = company.PLACE_ID;
            dbCompany.WEBSITE = company.WEBSITE;
            dbCompany.INT_NAME = company.INT_NAME;
            dbCompany.PUBLISH_WEB = company.PUBLISH_WEB;
            dbCompany.PUB_NEW_BUILD = company.PUB_NEW_BUILD;
            dbCompany.NAME_ABBRIVATION = company.NAME_ABBRIVATION;
            dbCompany.OFFICE2 = company.OFFICE2;
            dbCompany.MISC = company.MISC;
        }
    }
}
