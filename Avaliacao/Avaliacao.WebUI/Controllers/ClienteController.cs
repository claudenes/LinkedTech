using Avaliacao.Application.Dtos;
using Avaliacao.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao.WebUI.Controllers;

public class ClienteController : Controller
{
    private readonly IClienteService _clienteService;
    private readonly IEnderecoService _enderecoService;
    private readonly IWebHostEnvironment _environment;

    public ClienteController(IClienteService clienteService, IEnderecoService enderecoService, IWebHostEnvironment environment)
    {
        _clienteService = clienteService;
        _enderecoService = enderecoService;
        _environment = environment;

    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var clientes = _clienteService.ListClienteEnderecos();
        return View(await clientes);
    }
    [HttpGet]
    public async Task<IActionResult> Create()
    {
        return View();
    }
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        if (id == null)
            return NotFound();

        var clienteDto = await _clienteService.ClienteById(id);

        if (clienteDto == null) return NotFound();

        return View(clienteDto);
    }


    [HttpPost]
    public async Task<IActionResult> Create(ClienteDto clienteDto)
    {
        if (ModelState.IsValid)
        {
            await _clienteService.Create(clienteDto);
            return RedirectToAction(nameof(Index));
        }
        
        return View(clienteDto);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(ClienteDto clienteDto)
    {
        if (ModelState.IsValid)
        {
            await _clienteService.Update(clienteDto);
            return RedirectToAction(nameof(Index));
        }
        return View(clienteDto);
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        if (id == null)
            return NotFound();

        var livroDto = await _clienteService.Read(id);

        if (livroDto == null) return NotFound();

        return View(livroDto);
    }

    [HttpPost(), ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _clienteService.Delete(id);
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Details(int id)
    {
        if (id == null) return NotFound();

        var clienteDto = await _clienteService.Read(id);

        if (clienteDto == null) return NotFound();
        var wwwroot = _environment.WebRootPath;


        return View(clienteDto);
    }
}
