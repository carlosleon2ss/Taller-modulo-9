# Ejercicio: la tienda que no arranca

**Tiempo:** 20 minutos. **Temas:** inyección de dependencias y configuración.

Este proyecto tiene errores a propósito. Tu tarea es hacer que funcione.

## Reglas

1. Ejecuta `dotnet run` y lee el error completo.
2. Anota qué falta o qué está mal, y quién lo necesita.
3. Corrige solo la causa de ese error y vuelve a ejecutar.
4. Repite hasta que la API arranque.
5. No cambies las reglas de validación de `TiendaOptions`.

## Resultado esperado

Llama a `GET http://localhost:5000/api/tienda/resumen?subtotal=100` y recibe:

```json
{ "tienda": "Tienda Bootcamp", "moneda": "USD", "subtotal": 100, "total": 115 }
```

## Entrega

Completa una fila por cada error que encuentres:

| # | Mensaje principal | Causa | Corrección |
|---|---|---|---|
| 1 | | | |
| 2 | | | |
| 3 | | | |
| 4 | | | |

## Pregunta final

¿Por qué `ResumenService` no puede ser Singleton mientras use `IOptionsSnapshot`?
