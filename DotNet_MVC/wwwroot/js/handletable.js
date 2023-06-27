$(document).ready(function () {
    handleTable()
});

const handleTable = () => {
    $('#productListTb').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            { data:'id',"width":"5%"},
            { data: 'name', "width": "20%" },
            { data: 'description', "width": "30%" },
            { data: 'price', "width": "15%" },
            { data: 'category.name',"width":"15%" },
            {
                data: 'id',
                "width": "15%",
                "render": (data) => {
                    return `<div class="d-flex">

                            <a href="/admin/product/upsert?id=${data}" class="btn btn-warning d-flex mx-2">
                                <i class="bi bi-pencil px-2"></i>
                                <span>Edit</span>
                            </a>
                            <a href="/admin/product/delete?id=${data}" asp-route-id="id" class="btn btn-danger d-flex">
                                <i class="bi bi-trash px-2"></i>
                                <span>Delete</span>
                            </a>
                        </div>`

                }
            }
        ]
    });
}