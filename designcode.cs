﻿using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class order
    {
        public int id;
        public DateTime dia;
        public float precio;
        public string pais;
        public int numero;
        public int cantidad_producto;
        public int producto;
        public bool entrega()
        {
            return true;
        }
        public bool Pedido()
        {
            return true;
        }
    }
    

    public class product
    {
        public int id;
        public string nombre;
        public string marca;
        public string descripcion;
        public float preciobase;
        public float descuento;
        public float preciofinal;
        public bool visible()
        {
            return true;
        }
        public opiniones list<Product>;
        public category categoria;
        public int cantidad;
        public image image;
        public order order;
    }

    public class productosimple : product
    {
        public string categoria;
        public string subcategoria;
    }

    public class productocomplejo : product
    {
        public string categoria;
        public string subcategoria;
        public string subcategoria1;
    }
    
    public class Review
    {
        public string comentario;
        public int tratamiento_productos;
        public product productos_relacionados;
        public bool AddReview()
        {
            return true;
        }
        public product product;
        public user user;
    }
   


    public class user
    {
        public int id;
        public string nombre;
        public string apellidos;
        public string dni;
        public string email;
        public string telefono;
        public string direccion;
        public list list<product>;
        public order order; 
    }
    public class addres 
    {
        public string calle;
        public string ciudad;
        public int codigopostal;
        public string pais;
        public bool validate()
        {
            return true;
        }
        public user user;
    }
    public class shoppinglist
    {
        public list list<product>;
        public float preciofinal;
        public bool AddProduct()
        {
            return true;
        }
        public bool RemoveProduct()
        {
            return true;
        }
        public bool AddPay()
        {
            return true;
        }
        public user user;
    }
   
}
