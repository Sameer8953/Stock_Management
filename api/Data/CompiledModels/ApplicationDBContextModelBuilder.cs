﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#pragma warning disable 219, 612, 618
#nullable disable

namespace API.api.Data.CompiledModels
{
    public partial class ApplicationDBContextModel
    {
        partial void Initialize()
        {
            var comment = CommentEntityType.Create(this);
            var stock = StockEntityType.Create(this);

            CommentEntityType.CreateForeignKey1(comment, stock);

            CommentEntityType.CreateAnnotations(comment);
            StockEntityType.CreateAnnotations(stock);

            AddAnnotation("ProductVersion", "8.0.8");
            AddAnnotation("Relational:MaxIdentifierLength", 128);
            AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            AddRuntimeAnnotation("Relational:RelationalModel", CreateRelationalModel());
        }

        private IRelationalModel CreateRelationalModel()
        {
            var relationalModel = new RelationalModel(this);

            var comment = FindEntityType("api.Models.Comment")!;

            var defaultTableMappings = new List<TableMappingBase<ColumnMappingBase>>();
            comment.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings);
            var apiModelsCommentTableBase = new TableBase("api.Models.Comment", null, relationalModel);
            var contentColumnBase = new ColumnBase<ColumnMappingBase>("Content", "nvarchar(max)", apiModelsCommentTableBase);
            apiModelsCommentTableBase.Columns.Add("Content", contentColumnBase);
            var createdOnColumnBase = new ColumnBase<ColumnMappingBase>("CreatedOn", "datetime2", apiModelsCommentTableBase);
            apiModelsCommentTableBase.Columns.Add("CreatedOn", createdOnColumnBase);
            var idColumnBase = new ColumnBase<ColumnMappingBase>("Id", "int", apiModelsCommentTableBase);
            apiModelsCommentTableBase.Columns.Add("Id", idColumnBase);
            var stockIdColumnBase = new ColumnBase<ColumnMappingBase>("StockId", "int", apiModelsCommentTableBase)
            {
                IsNullable = true
            };
            apiModelsCommentTableBase.Columns.Add("StockId", stockIdColumnBase);
            var titleColumnBase = new ColumnBase<ColumnMappingBase>("Title", "nvarchar(max)", apiModelsCommentTableBase);
            apiModelsCommentTableBase.Columns.Add("Title", titleColumnBase);
            relationalModel.DefaultTables.Add("api.Models.Comment", apiModelsCommentTableBase);
            var apiModelsCommentMappingBase = new TableMappingBase<ColumnMappingBase>(comment, apiModelsCommentTableBase, true);
            apiModelsCommentTableBase.AddTypeMapping(apiModelsCommentMappingBase, false);
            defaultTableMappings.Add(apiModelsCommentMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)idColumnBase, comment.FindProperty("Id")!, apiModelsCommentMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)contentColumnBase, comment.FindProperty("Content")!, apiModelsCommentMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)createdOnColumnBase, comment.FindProperty("CreatedOn")!, apiModelsCommentMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)stockIdColumnBase, comment.FindProperty("StockId")!, apiModelsCommentMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)titleColumnBase, comment.FindProperty("Title")!, apiModelsCommentMappingBase);

            var tableMappings = new List<TableMapping>();
            comment.SetRuntimeAnnotation("Relational:TableMappings", tableMappings);
            var commentsTable = new Table("comments", null, relationalModel);
            var idColumn = new Column("Id", "int", commentsTable);
            commentsTable.Columns.Add("Id", idColumn);
            var contentColumn = new Column("Content", "nvarchar(max)", commentsTable);
            commentsTable.Columns.Add("Content", contentColumn);
            var createdOnColumn = new Column("CreatedOn", "datetime2", commentsTable);
            commentsTable.Columns.Add("CreatedOn", createdOnColumn);
            var stockIdColumn = new Column("StockId", "int", commentsTable)
            {
                IsNullable = true
            };
            commentsTable.Columns.Add("StockId", stockIdColumn);
            var titleColumn = new Column("Title", "nvarchar(max)", commentsTable);
            commentsTable.Columns.Add("Title", titleColumn);
            var pK_comments = new UniqueConstraint("PK_comments", commentsTable, new[] { idColumn });
            commentsTable.PrimaryKey = pK_comments;
            var pK_commentsUc = RelationalModel.GetKey(this,
                "api.Models.Comment",
                new[] { "Id" });
            pK_comments.MappedKeys.Add(pK_commentsUc);
            RelationalModel.GetOrCreateUniqueConstraints(pK_commentsUc).Add(pK_comments);
            commentsTable.UniqueConstraints.Add("PK_comments", pK_comments);
            var iX_comments_StockId = new TableIndex(
            "IX_comments_StockId", commentsTable, new[] { stockIdColumn }, false);
            var iX_comments_StockIdIx = RelationalModel.GetIndex(this,
                "api.Models.Comment",
                new[] { "StockId" });
            iX_comments_StockId.MappedIndexes.Add(iX_comments_StockIdIx);
            RelationalModel.GetOrCreateTableIndexes(iX_comments_StockIdIx).Add(iX_comments_StockId);
            commentsTable.Indexes.Add("IX_comments_StockId", iX_comments_StockId);
            relationalModel.Tables.Add(("comments", null), commentsTable);
            var commentsTableMapping = new TableMapping(comment, commentsTable, true);
            commentsTable.AddTypeMapping(commentsTableMapping, false);
            tableMappings.Add(commentsTableMapping);
            RelationalModel.CreateColumnMapping(idColumn, comment.FindProperty("Id")!, commentsTableMapping);
            RelationalModel.CreateColumnMapping(contentColumn, comment.FindProperty("Content")!, commentsTableMapping);
            RelationalModel.CreateColumnMapping(createdOnColumn, comment.FindProperty("CreatedOn")!, commentsTableMapping);
            RelationalModel.CreateColumnMapping(stockIdColumn, comment.FindProperty("StockId")!, commentsTableMapping);
            RelationalModel.CreateColumnMapping(titleColumn, comment.FindProperty("Title")!, commentsTableMapping);

            var stock = FindEntityType("api.Models.Stock")!;

            var defaultTableMappings0 = new List<TableMappingBase<ColumnMappingBase>>();
            stock.SetRuntimeAnnotation("Relational:DefaultMappings", defaultTableMappings0);
            var apiModelsStockTableBase = new TableBase("api.Models.Stock", null, relationalModel);
            var companyNameColumnBase = new ColumnBase<ColumnMappingBase>("CompanyName", "nvarchar(max)", apiModelsStockTableBase)
            {
                IsNullable = true
            };
            apiModelsStockTableBase.Columns.Add("CompanyName", companyNameColumnBase);
            var idColumnBase0 = new ColumnBase<ColumnMappingBase>("Id", "int", apiModelsStockTableBase);
            apiModelsStockTableBase.Columns.Add("Id", idColumnBase0);
            var industryColumnBase = new ColumnBase<ColumnMappingBase>("Industry", "nvarchar(max)", apiModelsStockTableBase);
            apiModelsStockTableBase.Columns.Add("Industry", industryColumnBase);
            var lastDivColumnBase = new ColumnBase<ColumnMappingBase>("LastDiv", "decimal(18,2)", apiModelsStockTableBase);
            apiModelsStockTableBase.Columns.Add("LastDiv", lastDivColumnBase);
            var marketCapColumnBase = new ColumnBase<ColumnMappingBase>("MarketCap", "bigint", apiModelsStockTableBase);
            apiModelsStockTableBase.Columns.Add("MarketCap", marketCapColumnBase);
            var purchaseColumnBase = new ColumnBase<ColumnMappingBase>("Purchase", "decimal(18,2)", apiModelsStockTableBase);
            apiModelsStockTableBase.Columns.Add("Purchase", purchaseColumnBase);
            var symbolColumnBase = new ColumnBase<ColumnMappingBase>("Symbol", "nvarchar(max)", apiModelsStockTableBase);
            apiModelsStockTableBase.Columns.Add("Symbol", symbolColumnBase);
            relationalModel.DefaultTables.Add("api.Models.Stock", apiModelsStockTableBase);
            var apiModelsStockMappingBase = new TableMappingBase<ColumnMappingBase>(stock, apiModelsStockTableBase, true);
            apiModelsStockTableBase.AddTypeMapping(apiModelsStockMappingBase, false);
            defaultTableMappings0.Add(apiModelsStockMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)idColumnBase0, stock.FindProperty("Id")!, apiModelsStockMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)companyNameColumnBase, stock.FindProperty("CompanyName")!, apiModelsStockMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)industryColumnBase, stock.FindProperty("Industry")!, apiModelsStockMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)lastDivColumnBase, stock.FindProperty("LastDiv")!, apiModelsStockMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)marketCapColumnBase, stock.FindProperty("MarketCap")!, apiModelsStockMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)purchaseColumnBase, stock.FindProperty("Purchase")!, apiModelsStockMappingBase);
            RelationalModel.CreateColumnMapping((ColumnBase<ColumnMappingBase>)symbolColumnBase, stock.FindProperty("Symbol")!, apiModelsStockMappingBase);

            var tableMappings0 = new List<TableMapping>();
            stock.SetRuntimeAnnotation("Relational:TableMappings", tableMappings0);
            var stocksTable = new Table("Stocks", null, relationalModel);
            var idColumn0 = new Column("Id", "int", stocksTable);
            stocksTable.Columns.Add("Id", idColumn0);
            var companyNameColumn = new Column("CompanyName", "nvarchar(max)", stocksTable)
            {
                IsNullable = true
            };
            stocksTable.Columns.Add("CompanyName", companyNameColumn);
            var industryColumn = new Column("Industry", "nvarchar(max)", stocksTable);
            stocksTable.Columns.Add("Industry", industryColumn);
            var lastDivColumn = new Column("LastDiv", "decimal(18,2)", stocksTable);
            stocksTable.Columns.Add("LastDiv", lastDivColumn);
            var marketCapColumn = new Column("MarketCap", "bigint", stocksTable);
            stocksTable.Columns.Add("MarketCap", marketCapColumn);
            var purchaseColumn = new Column("Purchase", "decimal(18,2)", stocksTable);
            stocksTable.Columns.Add("Purchase", purchaseColumn);
            var symbolColumn = new Column("Symbol", "nvarchar(max)", stocksTable);
            stocksTable.Columns.Add("Symbol", symbolColumn);
            var pK_Stocks = new UniqueConstraint("PK_Stocks", stocksTable, new[] { idColumn0 });
            stocksTable.PrimaryKey = pK_Stocks;
            var pK_StocksUc = RelationalModel.GetKey(this,
                "api.Models.Stock",
                new[] { "Id" });
            pK_Stocks.MappedKeys.Add(pK_StocksUc);
            RelationalModel.GetOrCreateUniqueConstraints(pK_StocksUc).Add(pK_Stocks);
            stocksTable.UniqueConstraints.Add("PK_Stocks", pK_Stocks);
            relationalModel.Tables.Add(("Stocks", null), stocksTable);
            var stocksTableMapping = new TableMapping(stock, stocksTable, true);
            stocksTable.AddTypeMapping(stocksTableMapping, false);
            tableMappings0.Add(stocksTableMapping);
            RelationalModel.CreateColumnMapping(idColumn0, stock.FindProperty("Id")!, stocksTableMapping);
            RelationalModel.CreateColumnMapping(companyNameColumn, stock.FindProperty("CompanyName")!, stocksTableMapping);
            RelationalModel.CreateColumnMapping(industryColumn, stock.FindProperty("Industry")!, stocksTableMapping);
            RelationalModel.CreateColumnMapping(lastDivColumn, stock.FindProperty("LastDiv")!, stocksTableMapping);
            RelationalModel.CreateColumnMapping(marketCapColumn, stock.FindProperty("MarketCap")!, stocksTableMapping);
            RelationalModel.CreateColumnMapping(purchaseColumn, stock.FindProperty("Purchase")!, stocksTableMapping);
            RelationalModel.CreateColumnMapping(symbolColumn, stock.FindProperty("Symbol")!, stocksTableMapping);
            var fK_comments_Stocks_StockId = new ForeignKeyConstraint(
                "FK_comments_Stocks_StockId", commentsTable, stocksTable,
                new[] { stockIdColumn },
                stocksTable.FindUniqueConstraint("PK_Stocks")!, ReferentialAction.NoAction);
            var fK_comments_Stocks_StockIdFk = RelationalModel.GetForeignKey(this,
                "api.Models.Comment",
                new[] { "StockId" },
                "api.Models.Stock",
                new[] { "Id" });
            fK_comments_Stocks_StockId.MappedForeignKeys.Add(fK_comments_Stocks_StockIdFk);
            RelationalModel.GetOrCreateForeignKeyConstraints(fK_comments_Stocks_StockIdFk).Add(fK_comments_Stocks_StockId);
            commentsTable.ForeignKeyConstraints.Add(fK_comments_Stocks_StockId);
            stocksTable.ReferencingForeignKeyConstraints.Add(fK_comments_Stocks_StockId);
            return relationalModel.MakeReadOnly();
        }
    }
}
