﻿namespace MW5.Data.Repository
{
    public enum RepositoryItemType
    {
        FileSystem = 0,
        Folder = 1,
        Vector = 2,
        Databases = 3,
        PostGis = 4,
        Database = 5,
        Image = 6,
    }

    public enum RepositorIcon
    {
         FileSystem = 0,
         Folder = 1,
         Point = 2,
         Line = 3,
         Polygon = 4,
         Geometry = 5,
         Databases = 6,
         Database = 7,
         PostGis = 8,
         Raster = 9,
    }

    public enum FormatType
    {
        All = 0,
        Vector = 1,
        Raster = 2,
        Grid = 3,
    }
}