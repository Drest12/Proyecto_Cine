import React, { useEffect, useState } from 'react';

const PeliPorFecha = () => {
    // variables de estado
    const [fecha_estreno, setfecha_estreno] = useState('')
    const [lista, setLista] = useState([])
    // funcion para capturar la informacion del 
    // teclado y asignarlo a la variable anio
    // a traves de su metodo setfecha_estreno
    const handlerAnio = (e) => {
        setfecha_estreno(e.target.value)
        //console.log(e.target.value)    
    }
    // función asincrona que devuelva los datos de un servicio
    const traerFecha = async (fecha_estreno) => {
        // ALT + 96 = `
        console.log(fecha_estreno)
        const consulta =
            await fetch(`http://localhost:58007/api/PeliPorFecha/GETPeliPorFecha/${fecha_estreno}`)
        // el resultado valor a convertirlo a json
        const datos = await consulta.json();
        // almacenando la información en json dentro de lista
        setLista(datos)
    }
    useEffect(() => {
        // llamar a funciones o ejecutar codigo
        traerFecha(fecha_estreno)
    }, [fecha_estreno])
    return (
        <div><br/>
            <h1 className='text-primary'>Consulta de Fecha de Estreno</h1>
                <div className='col-md-4'>
                <h5>Año a Consultar: </h5>
                <input type="text"
                    name="fecha_estreno"
                    value={fecha_estreno}
                    onChange={handlerAnio}
                    className='form-control'
                />
            </div>
            <hr />
                <table className='table table-bordered '>
                    <thead className='bg-primary text-white text-center'>
                        <tr>
                            <th>Codigo</th>
                            <th>Pelicula</th>
                            <th>Sipnosis</th>
                            <th>Genero</th>
                            <th>Fecha de Estreno</th>
                            <th>Duracion</th>
                            <th>Clasificacion</th>
                        </tr>
                    </thead>
                    <tbody className='text-center'>
                        {
                            lista.map((item, index) => {
                                return <tr key={index}>
                                    <td>{item.id_pelicula}</td>
                                    <td>{item.nom_pelicula}</td>
                                    <td>{item.sipnosis}</td>
                                    <td>{item.genero}</td>
                                    <td>{item.fecha_estreno}</td>
                                    <td>{item.duracion_horas}</td>
                                    <td>{item.clasificacion}</td>
                                </tr>
                            })
                        }
                    </tbody>
                </table>
        </div>
    )
}
export default PeliPorFecha