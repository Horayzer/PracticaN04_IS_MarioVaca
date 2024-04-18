using System;
using System.Collections.Generic;
using Data;
using DataAccess;
using Logic;

namespace Test
{
    public class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Data \n2) Logic");
            int num;
            if (int.TryParse(Console.ReadLine(), out num))
            {
                switch (num)
                {
                    case 0:
                        // Probar la capa de Datos (Data)
                        Console.WriteLine("Probando la capa de Datos (Data):");

                        DataCliente data = new DataCliente();
                        List<cliente> listaClientes = data.Listar();
                        foreach (var cliente in listaClientes)
                        {
                            Console.WriteLine($"ID: {cliente.id}, Nombre: {cliente.nombre}, Cédula: {cliente.cedula}");
                        }
                        Console.WriteLine();

                        Console.ReadKey();
                        break;
                    case 1:
                        // Probar la capa de Lógica (Logic)
                        Console.WriteLine("Probando la capa de Lógica (Logic):");
                        LogicCliente logic = new LogicCliente();

                        List<cliente> listaClientesLogic = logic.ListarClientes(); //Listar
                        Console.WriteLine("1) Listar \n2) Insertar \n3) Actualizar\n4) Eliminar");
                        int op;
                        if (int.TryParse(Console.ReadLine(),out op))
                        {
                            switch(op)
                            {
                                case 0:

                                    //Listar clientes
                                    foreach (var cliente in listaClientesLogic)
                                    {
                                        Console.WriteLine($"ID: {cliente.id}, Nombre: {cliente.nombre}, Cédula: {cliente.cedula}");
                                    }
                                    Console.WriteLine();

                                    Console.ReadKey();
                                    break;
                                case 1:

                                    // Insertar un nuevo cliente

                                    Console.WriteLine("Insertando un nuevo cliente:");
                                    cliente nuevoCliente = new cliente
                                    {
                                        cedula = "123456789",
                                        nombre = "Nuevo Cliente",
                                        direccion = "Calle Principal",
                                        telefono = "1234567890",
                                        idCategoria = 1
                                    };

                                    bool insertado = logic.AñadirCliente(nuevoCliente);
                                    if (insertado)
                                    {
                                        Console.WriteLine("Nuevo cliente insertado correctamente.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error al insertar el nuevo cliente.");
                                    }
                                    Console.WriteLine();

                                    Console.ReadKey();
                                    break;
                                case 2:

                                    // Actualizar el nombre de un cliente existente

                                    Console.WriteLine("Actualizando el nombre de un cliente existente:");
                                    var clienteExistente = listaClientesLogic[0]; // Tomamos el primer cliente de la lista para actualizar
                                    clienteExistente.nombre = "Actualizar";
                                    bool actualizado = logic.ActualizarCliente(clienteExistente);
                                    if (actualizado)
                                    {
                                        Console.WriteLine("Nombre del cliente actualizado correctamente.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error al actualizar el nombre del cliente.");
                                    }
                                    Console.WriteLine();

                                    Console.ReadKey();
                                    break;
                                case 3:


                                    // Eliminar un cliente existente
                                    Console.WriteLine("Eliminando un cliente existente:");
                                    var clienteAEliminar = listaClientesLogic[0]; // Tomamos el primer cliente de la lista para eliminar
                                    bool eliminado = logic.EliminarCliente(clienteAEliminar);
                                    if (eliminado)
                                    {
                                        Console.WriteLine("Cliente eliminado correctamente.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error al eliminar el cliente.");
                                    }
                                    Console.WriteLine();

                                    
                                    Console.ReadKey();

                                    break;
                                default:
                                    
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Opcion Invalida");
                        break;
                }
            }
        }
    }
}

