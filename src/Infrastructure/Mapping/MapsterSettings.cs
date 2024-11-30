using Mapster;
using TD.KCN.WebApi.Application.House.Motels;
using TD.KCN.WebApi.Domain.House;
namespace TD.KCN.WebApi.Infrastructure.Mapping;

public class MapsterSettings
{
    public static void Configure()
    {
        // here we will define the type conversion / Custom-mapping
        // More details at https://github.com/MapsterMapper/Mapster/wiki/Custom-mapping

        // This one is actually not necessary as it's mapped by convention
        // TypeAdapterConfig<Product, ProductDto>.NewConfig().Map(dest => dest.BrandName, src => src.Brand.Name);
        //TypeAdapterConfig<Motel, MotelDto>
        //    .NewConfig()
        //    .Map(dest => dest.UserAvatar, src => src..IndustrialPark.Name);

        //TypeAdapterConfig<OvertimeRegister, OvertimeRegisterDto>
        //    .NewConfig()
        //    .Map(dest => dest.IndustrialParkName, src => src.Company.IndustrialPark.Name);

        //TypeAdapterConfig<RegulaRegister, RegulaRegisterDto>
        //    .NewConfig()
        //    .Map(dest => dest.IndustrialParkName, src => src.Company.IndustrialPark.Name)
        //    .Map(dest => dest.IndustrialParkId, src => src.Company.IndustrialPark.Id);

        //TypeAdapterConfig<WorkPermit, WorkPermitDto>
        //    .NewConfig()
        //    .Map(dest => dest.CompanyCode, src => src.Company.Code)
        //    .Map(dest => dest.FieldType, src => src.Company.FieldType)
        //    .Map(dest => dest.IndustrialParkId, src => src.Company.IndustrialParkId)
        //    .Map(dest => dest.IndustrialParkName, src => src.Company.IndustrialPark.Name)
        //    .Map(dest => dest.Place, src => src.Company.Place);

        //TypeAdapterConfig<LaborAgreement, LaborAgreementDto>
        //    .NewConfig()
        //    .Map(dest => dest.IndustrialParkName, src => src.Company.IndustrialPark.Name);

        //TypeAdapterConfig<MetricInTemplate, MetricInTemplateDto>
        //    .NewConfig()
        //    .Map(dest => dest.ParentId, src => src.ReportMetric.ParentId == null ? null : src.ReportMetric.ParentId)
        //    .Map(dest => dest.ReportMetricCode, src => src.ReportMetric.Code);
    }
}