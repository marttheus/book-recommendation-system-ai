using System.Collections.Generic;
using System.Linq;
using Asp.Versioning;
using BookRecommendationSystemAI.Domain.Model.Entities;
using BookRecommendationSystemAI.Infra.Context;
using Microsoft.AspNetCore.Mvc;

namespace BookRecommendationSystemAI.API.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/books")]
public class BookController : ControllerBase
{
    private readonly PostgresDbContext _postgresDbContext;

    public BookController(PostgresDbContext postgresDbContext)
    {
        _postgresDbContext = postgresDbContext;
    }

    [HttpGet]
    public List<Book> SearchBooks()
        => _postgresDbContext.Books.ToList();
}