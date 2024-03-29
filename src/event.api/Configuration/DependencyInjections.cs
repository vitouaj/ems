﻿using AutoMapper;
using EventAPI.Abstactions;
using EventAPI.Data;
using EventAPI.Models;
using EventAPI.Services;

namespace EventAPI;

public static class DependencyInjections
{
    public static IServiceCollection AddDefaultServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();
        services.AddDateOnlyTimeOnlyStringConverters();
        
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c => c.UseDateOnlyTimeOnlyStringConverters());



        services.AddAutoMapper(typeof(DependencyInjections));

        services.AddScoped<IEventRepository, EventRepository>();
        services.AddScoped<ISessionRepository, SessionRepository>();

        return services;
    }
}
