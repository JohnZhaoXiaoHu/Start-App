﻿// Copyright (c) Trickyrat All Rights Reserved.
// Licensed under the MIT LICENSE.

using AutoMapper;
using Start_App.Domain.Dtos;
using Start_App.Domain.Entities;

namespace Start_App.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(
                dest => dest.CompanyName,
                opt => opt.MapFrom(src => src.Name));

            CreateMap<CompanyDto, Company>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.CompanyName));

        }
    }
}
