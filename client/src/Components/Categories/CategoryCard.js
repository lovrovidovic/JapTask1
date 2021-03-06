import React from "react";
import { useHistory } from "react-router-dom";
import Card from "@mui/material/Card";
import CardActions from "@mui/material/CardActions";
import CardContent from "@mui/material/CardContent";
import Button from "@mui/material/Button";
import Typography from "@mui/material/Typography";
import { generateLink, routesConfiguration as routes} from '../../Router/routes'

export const CategoryCard = ({ name, categoryId }) => {
  const history = useHistory();

  const clickRecipeHandler = () => {
    history.push(generateLink(routes.RECIPES, {id: categoryId}));
  }

  return (
    <Card sx={{ maxWidth: 450, display: "inline-block", margin: "50px" }}>
      <CardContent>
        <Typography variant="body2">{name}</Typography>
      </CardContent>
      <CardActions>
        <Button size="small" onClick={clickRecipeHandler}>Browse recipes</Button>
      </CardActions>
    </Card>
  );
};
