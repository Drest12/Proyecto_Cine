import React, { useEffect, useState } from 'react';

const STOCKSPE = () => {
    // variables de estado
    const [sto_producto, setsto_producto] = useState('')
    const [lista, setLista] = useState([])
    // funcion para capturar la informacion del 
    // teclado y asignarlo a la variable anio
    // a traves de su metodo setsto_producto
    const handlersto_producto = (e) => {
        setsto_producto(e.target.value)
        //console.log(e.target.value)    
    }
    // función asincrona que devuelva los datos de un servicio
    const traerStock = async (sto_producto) => {
        // ALT + 96 = `
        console.log(sto_producto)
        const consulta =
            await fetch(`http://localhost:58007/api/STOCKSPE/GETSTOCKSPE/${sto_producto}`)
        // el resultado valor a convertirlo a json
        const datos = await consulta.json();
        // almacenando la información en json dentro de lista
        setLista(datos)
    }
    useEffect(() => {
        // llamar a funciones o ejecutar codigo
        traerStock(sto_producto)
    }, [sto_producto])
    return (
        <div><br/>
            <h1 className='text-primary'>Consulta de Stock</h1>
                <div className='col-md-4'>
                <h5>Stock a Consultar: </h5>
                <input type="text"
                    name="sto_producto"
                    value={sto_producto}
                    onChange={handlersto_producto}
                    className='form-control'
                />
            </div>
            <hr />
                <table className='table table-bordered '>
                    <thead className='bg-primary text-white text-center'>
                        <tr>
                            <th>Codigo</th>
                            <th>Producto</th>
                            <th>Descripcion</th>
                            <th>Precio</th>
                            <th>Stock</th>
                       
                        </tr>
                    </thead>
                    <tbody className='text-center'>
                        {
                            lista.map((item, index) => {
                                return <tr key={index}>
                                    <td>{item.id_producto}</td>
                                    <td>{item.nom_producto}</td>
                                    <td>{item.des_producto}</td>
                                    <td>{item.pre_producto}</td>
                                    <td>{item.sto_producto}</td>
                                </tr>
                            })
                        }
                    </tbody>
                </table>
        </div>
    )
}
export default STOCKSPE