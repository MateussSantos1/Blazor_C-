﻿namespace Crud_Blazor_EF.Models
{
    public class Categoria
    {

        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Descricao { get; set; } = string.Empty;
    }
}
