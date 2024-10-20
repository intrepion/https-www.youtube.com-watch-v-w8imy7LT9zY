﻿using BlazorCrudDotNet8.BusinessLogic.Entities.Dtos.Admin;

namespace BlazorCrudDotNet8.BusinessLogic.Entities.ViewModels.Admin;

public class GameAdminEditViewModel
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;
    // JustModelPropertyPlaceholder

    public static GameAdminEditViewModel FromGameAdminDto(GameAdminDto gameAdminDto)
    {
        if (gameAdminDto == null)
        {
            return new GameAdminEditViewModel();
        }

        return new GameAdminEditViewModel
        {
            Id = gameAdminDto.Id,

            Name = gameAdminDto.Name,
            // DtoToModelPlaceholder
        };
    }

    public static GameAdminDto ToGameAdminDto(GameAdminEditViewModel gameAdminEditViewModel)
    {
        if (gameAdminEditViewModel == null)
        {
            return new GameAdminDto();
        }

        return new GameAdminDto
        {
            Id = gameAdminEditViewModel.Id,

            Name = gameAdminEditViewModel.Name,
            // ModelToDtoPlaceholder
        };
    }
}
